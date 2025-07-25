
using System;
using System.Windows.Forms;
using fa.Services;
using fa.Views;

namespace fa
{
    public partial class Form1 : Form
    {
        private readonly BillingView _billingView;
        private readonly ProductsView _productsView;

        public Form1()
        {
            InitializeComponent();
            
            _productsView = new ProductsView();
            _billingView = new BillingView();
            
            SetupNavigation();
        }

        /// <summary>
        /// Configure la navigation principale et l'interface de la fenêtre.
        /// </summary>
        private void SetupNavigation()
        {
            billingButton.Text = "Facturation";
            productsButton.Text = "Produits";
            this.Text = $"Système de Facturation - {SessionManager.StoreInfo.Name}";
            cashierStatusLabel.Text = $"Caissier : {SessionManager.CashierName}";

            billingButton.Click += (sender, e) => ShowView(_billingView);
            productsButton.Click += (sender, e) => ShowView(_productsView);

            // Affiche la vue de facturation par défaut au démarrage.
            ShowView(_billingView);
        }

        /// <summary>
        /// Affiche une vue (UserControl) dans le panneau principal.
        /// Optimisé pour ne pas recharger la vue si elle est déjà affichée.
        /// </summary>
        /// <param name="view">La vue à afficher.</param>
        private void ShowView(Control view)
        {
            if (!mainPanel.Controls.Contains(view))
            {
                mainPanel.Controls.Clear();
                view.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(view);
            }
        }
    }
}

