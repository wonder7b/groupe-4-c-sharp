using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation_magasin { 
    public partial class Initiation : Form
    {
        public Initiation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if(textBoxNom.Text != "" && textBoxAdresseMail.Text != "" && textBoxAdressePhysique.Text != "" && textBoxNumero.Text != "")
            {
                Utilisateur utilisateur = new Utilisateur();
                utilisateur.Nom = textBoxNom.Text;
                utilisateur.Adresse = textBoxAdressePhysique.Text;
                utilisateur.Email = textBoxAdresseMail.Text;
                utilisateur.Telephone = textBoxNumero.Text;
                UtilisateurDB db = new UtilisateurDB();
                db.Inserer(utilisateur);
                MessageBox.Show("Utilisateur enregistré");
                ProduitForm form = new ProduitForm();
                form.Show();
                
            }
            else
            {
                MessageBox.Show("Veuillez taper sur tous les champs");
            }
        }

        private void Initiation_Load(object sender, EventArgs e)
        {

        }
    }
}
