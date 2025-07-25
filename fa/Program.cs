using fa.Services;
using fa.Views;

namespace fa;

static class Program
{
    /// <summary>
    ///  Le point d'entrée principal de l'application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Initialise les services critiques : configuration et base de données.
        SessionManager.Initialize();
        DatabaseService.InitializeDatabase();

        // Affiche le formulaire de connexion.
        using (var loginForm = new LoginForm())
        {
            // Si la connexion réussit, lance l'application principale.
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            // Sinon, l'application se ferme simplement.
        }
    }
}
