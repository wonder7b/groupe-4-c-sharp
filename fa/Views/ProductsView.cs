using fa.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using fa.Models;
using fa.Services;
using Microsoft.EntityFrameworkCore;

namespace fa.Views
{
    public partial class ProductsView : UserControl
    {
        private AppDbContext _dbContext;
        private Product _selectedProduct;
        public event EventHandler ProductsChanged;

        public ProductsView()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            SetupUI();
            LoadProducts();
        }

        private void SetupUI()
        {
            taxCategoryComboBox.DataSource = Enum.GetValues(typeof(TaxCategory));
            productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.ReadOnly = true;
            productsDataGridView.MultiSelect = false;
            productsDataGridView.AllowUserToAddRows = false;

            addProductButton.Click += SaveButton_Click;
            deleteProductButton.Click += DeleteButton_Click;
            clearFormButton.Click += (s, e) => ClearForm();
            productsDataGridView.SelectionChanged += ProductsDataGridView_SelectionChanged;
            
            this.Text = "Gestion des Produits";
            groupBox.Text = "Détails du Produit";
            codeLabel.Text = "Code :";
            nameLabel.Text = "Nom :";
            priceLabel.Text = "Prix :";
            taxCategoryLabel.Text = "Catégorie TVA :";
            addProductButton.Text = "Enregistrer";
            deleteProductButton.Text = "Supprimer";
            clearFormButton.Text = "Nouveau";
        }

        private void LoadProducts()
        {
            _dbContext.Products.Load();
            productsDataGridView.DataSource = _dbContext.Products.Local.ToBindingList();
            FormatColumns();
            ProductsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void FormatColumns()
        {
            if (productsDataGridView.Columns["Price"] != null)
            {
                productsDataGridView.Columns["Price"].DefaultCellStyle.Format = "C";
                productsDataGridView.Columns["Price"].DefaultCellStyle.FormatProvider = CultureHelper.CongoleseFranc;
            }
            if (productsDataGridView.Columns["Id"] != null)
            {
                productsDataGridView.Columns["Id"].Visible = false;
            }
        }

        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                _selectedProduct = (Product)productsDataGridView.SelectedRows[0].DataBoundItem;
                codeTextBox.Text = _selectedProduct.Code;
                nameTextBox.Text = _selectedProduct.Nom;
                priceNumericUpDown.Value = _selectedProduct.Prix;
                taxCategoryComboBox.SelectedItem = _selectedProduct.Categorie;
                deleteProductButton.Enabled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var code = codeTextBox.Text.Trim();
            var nom = nameTextBox.Text.Trim();
            var prix = priceNumericUpDown.Value;
            var categorie = (TaxCategory)taxCategoryComboBox.SelectedItem;

            if (!ValidateInput(code, nom, prix)) return;

            if (_selectedProduct == null) // Add new product
            {
                var newProduct = new Product
                {
                    Code = code,
                    Nom = nom,
                    Prix = prix,
                    Categorie = categorie
                };
                _dbContext.Products.Add(newProduct);
            }
            else // Update existing product
            {
                _selectedProduct.Code = code;
                _selectedProduct.Nom = nom;
                _selectedProduct.Prix = prix;
                _selectedProduct.Categorie = categorie;
                _dbContext.Products.Update(_selectedProduct);
            }

            try
            {
                _dbContext.SaveChanges();
            }
            catch (DbUpdateException ex) when (ex.InnerException?.Message.Contains("UNIQUE constraint failed") ?? false)
            {
                MessageBox.Show($"Le code produit '{code}' existe déjà. Veuillez en utiliser un autre.", "Erreur de duplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            LoadProducts();
            ClearForm();
        }

        private bool ValidateInput(string code, string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name) || price <= 0)
            {
                MessageBox.Show("Les champs 'Code', 'Nom' et 'Prix' sont obligatoires et le prix doit être positif.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(code, out _))
            {
                MessageBox.Show("Le code produit ne doit contenir que des chiffres.", "Format de code invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedProduct != null)
            {
                var result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le produit '{_selectedProduct.Nom}' ?", 
                                             "Confirmation de suppression", 
                                             MessageBoxButtons.YesNo, 
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _dbContext.Products.Remove(_selectedProduct);
                    _dbContext.SaveChanges();
                    LoadProducts();
                    ClearForm();
                }
            }
        }

        private void ClearForm()
        {
            _selectedProduct = null;
            codeTextBox.Clear();
            nameTextBox.Clear();
            priceNumericUpDown.Value = 0;
            taxCategoryComboBox.SelectedIndex = 0;
            productsDataGridView.ClearSelection();
            deleteProductButton.Enabled = false;
            codeTextBox.Focus();
        }
        
        public List<Product> GetProducts()
        {
            return _dbContext.Products.AsNoTracking().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ClearForm();
        }
    }
}

