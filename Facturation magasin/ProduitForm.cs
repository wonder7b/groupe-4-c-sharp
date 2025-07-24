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
    partial class ProduitForm : Form
    {
        public ProduitForm()
        {
            InitializeComponent();
        }

        #region Accesseurs d'attribut de l'assembly

        

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ProduitForm_Load(object sender, EventArgs e)
        {
            listView.Columns.Add("Nom", 120);
            listView.Columns.Add("Prix", 150);
            listView.Columns.Add("Categorie", 60);
            listView.Columns.Add("code", 100);
        }
        private void ChargerUtilisateurs()
        {
            listView.Items.Clear();
            ProduitDB db = new ProduitDB();
            List<Produit> liste = db.LireProduits();

            foreach (var u in liste)
            {
                ListViewItem item = new ListViewItem(u.Nom);
                item.SubItems.Add(Convert.ToString(u.Prix));
                item.SubItems.Add(u.Categorie);
                item.SubItems.Add(u.Code);

                listView.Items.Add(item);
            }
        }

    }
}
