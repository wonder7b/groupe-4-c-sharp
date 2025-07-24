using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation_magasin
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UtilisateurDB db = new UtilisateurDB();
            if (db.Verifier())
            {
                Application.Run(new ProduitForm());
            }
            else
            {
                Application.Run(new Initiation());
            }
            
        }
    }
}
