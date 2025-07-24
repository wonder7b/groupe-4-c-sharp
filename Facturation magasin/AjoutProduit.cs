using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation_magasin
{
    partial class AjoutProduit : Form
    {
        public AjoutProduit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxCodeBar.Text != "" && textBoxCodeBar.Text != "" && comboBoxCategorie.Text != "")
            {
                ProduitDB db = new ProduitDB();
                Produit produit = new Produit();
                produit.Nom = textBoxNom.Text;
                produit.Code = textBoxCodeBar.Text;
                produit.Prix = Convert.ToDecimal(textBoxPrix.Text);
                produit.Categorie = comboBoxCategorie.Text;
                db.AjouterProduit(produit);
                MessageBox.Show("Enregistrer");
            }
            else
            {
                MessageBox.Show("Tapez sur tous les champs !");
            }

        }
    }
}
