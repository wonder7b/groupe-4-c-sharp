using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fa.Helpers;
using fa.Models;
using fa.Services;

namespace fa.Views
{
    public partial class BillingView : UserControl
    {
        private BindingList<CartItem> _cart;
        private AppDbContext _dbContext;
        private Product _foundProduct;

        public BillingView()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            SetupUI();
        }

        private void SetupUI()
        {
            _cart = new BindingList<CartItem>();
            cartDataGridView.DataSource = _cart;
            
            FormatCartGrid();
            
            // Configuration des événements
            searchProductButton.Click += SearchProductButton_Click;
            addToCartButton.Click += AddToCartButton_Click;
            printReceiptButton.Click += PrintReceiptButton_Click;
            deleteFromCartButton.Click += DeleteFromCartButton_Click;
            productCodeTextBox.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) SearchProductButton_Click(s, e); };
            quantityNumericUpDown.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) AddToCartButton_Click(s, e); };

            // Traduction et configuration des textes
            customerInfoGroupBox.Text = "Informations du Client";
            customerNameLabel.Text = "Nom du client :";
            customerPhoneLabel.Text = "N° de téléphone :";
            productSearchGroupBox.Text = "Recherche de Produit";
            productCodeLabel.Text = "Code produit :";
            searchProductButton.Text = "Rechercher";
            addToCartButton.Text = "Ajouter au Panier";
            deleteFromCartButton.Text = "Retirer du Panier";
            printReceiptButton.Text = "Finaliser et Nouveau Ticket";
            subTotalLabel.Text = "Sous-total :";
            taxLabel.Text = "TVA :";
            totalLabel.Text = "TOTAL :";
        }
        
        private void FormatCartGrid()
        {
            cartDataGridView.AutoGenerateColumns = false;
            if (cartDataGridView.Columns.Count == 0)
            {
                cartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Product.Code", HeaderText = "Code", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
                cartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Product.Name", HeaderText = "Produit", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 40 });
                cartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qté", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
                cartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Product.Price", HeaderText = "Prix Unit.", DefaultCellStyle = { Format = "C", FormatProvider = CultureHelper.CongoleseFranc }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
                cartDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalPrice", HeaderText = "Total", DefaultCellStyle = { Format = "C", FormatProvider = CultureHelper.CongoleseFranc }, AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            }
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            var productCode = productCodeTextBox.Text.Trim();
            if (string.IsNullOrEmpty(productCode)) return;

            _foundProduct = _dbContext.Products.FirstOrDefault(p => p.Code == productCode);

            if (_foundProduct != null)
            {
                foundProductNameLabel.Text = _foundProduct.Name;
                addToCartButton.Enabled = true;
                quantityNumericUpDown.Focus();
            }
            else
            {
                MessageBox.Show("Aucun produit trouvé avec ce code.", "Produit non trouvé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                foundProductNameLabel.Text = "Aucun produit sélectionné";
                addToCartButton.Enabled = false;
                _foundProduct = null;
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_foundProduct == null) return;
            
            var quantity = (int)quantityNumericUpDown.Value;
            var existingCartItem = _cart.FirstOrDefault(item => item.Product.Id == _foundProduct.Id);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity += quantity;
                _cart.ResetBindings(); 
            }
            else
            {
                _cart.Add(new CartItem { Product = _foundProduct, Quantity = quantity });
            }
            
            UpdateTotals();
            ResetProductSearch();
        }

        private void DeleteFromCartButton_Click(object sender, EventArgs e)
        {
            if (cartDataGridView.SelectedRows.Count > 0)
            {
                var selectedCartItem = (CartItem)cartDataGridView.SelectedRows[0].DataBoundItem;
                _cart.Remove(selectedCartItem);
                UpdateTotals();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un article à retirer du panier.", "Aucun article sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateTotals()
        {
            decimal subTotal = _cart.Sum(item => item.TotalPrice);
            decimal taxAmount = _cart.Sum(item => CalculateTax(item.Product) * item.Quantity);
            decimal total = subTotal + taxAmount;

            subTotalValueLabel.Text = subTotal.ToString("C", CultureHelper.CongoleseFranc);
            taxValueLabel.Text = taxAmount.ToString("C", CultureHelper.CongoleseFranc);
            totalValueLabel.Text = total.ToString("C", CultureHelper.CongoleseFranc);
        }

        private decimal GetTaxRate(TaxCategory category) => category switch
        {
            TaxCategory.A => 0.16m,
            TaxCategory.B => 0.12m,
            TaxCategory.C => 0.08m,
            _ => 0
        };
        
        private decimal CalculateTax(Product product)
        {
            decimal taxRate = GetTaxRate(product.TaxCategory);
            return product.Price * taxRate;
        }

        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Le panier est vide. Impossible de finaliser la transaction.", "Panier Vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var receipt = GenerateReceipt();
            MessageBox.Show(receipt, "Ticket de Caisse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ResetTransaction();
        }

        private string GenerateReceipt()
        {
            var sb = new StringBuilder();
            var store = SessionManager.StoreInfo;
            var customerName = customerNameTextBox.Text.Trim();
            var customerPhone = customerPhoneTextBox.Text.Trim();

            sb.AppendLine($"----------- {store.Name} -----------");
            sb.AppendLine(store.Address);
            sb.AppendLine(store.Email);
            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"Date : {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine($"Caissier : {SessionManager.CashierName}");
            if (!string.IsNullOrEmpty(customerName))
                sb.AppendLine($"Client : {customerName} ({customerPhone})");
            sb.AppendLine("----------------------------------------");

            foreach (var item in _cart)
            {
                var formattedPrice = item.TotalPrice.ToString("C", CultureHelper.CongoleseFranc);
                sb.AppendLine($"{item.Product.Name,-20} (x{item.Quantity}) {formattedPrice,15}");
            }

            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"Sous-total : {subTotalValueLabel.Text,25}");
            sb.AppendLine($"TVA : {taxValueLabel.Text,32}");
            sb.AppendLine($"TOTAL : {totalValueLabel.Text,28}");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"         {store.ReceiptFooter}");

            return sb.ToString();
        }

        private void ResetProductSearch()
        {
            _foundProduct = null;
            productCodeTextBox.Clear();
            foundProductNameLabel.Text = "Aucun produit sélectionné";
            addToCartButton.Enabled = false;
            quantityNumericUpDown.Value = 1;
            productCodeTextBox.Focus();
        }

        private void ResetTransaction()
        {
            _cart.Clear();
            UpdateTotals();
            customerNameTextBox.Clear();
            customerPhoneTextBox.Clear();
            ResetProductSearch();
        }
    }
}


