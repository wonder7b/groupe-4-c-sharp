using fa.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace fa.Services
{
    /// <summary>
    /// Gère les informations de la session courante, comme le caissier
    /// et les détails du magasin. C'est une classe statique, ce qui signifie
    /// qu'il n'y a qu'une seule instance de ces informations pour toute l'application.
    /// </summary>
    public static class SessionManager
    {
        /// <summary>
        /// Obtient les informations sur le magasin, chargées depuis appsettings.json.
        /// La propriété est en lecture seule de l'extérieur pour éviter les modifications accidentelles.
        /// </summary>
        public static StoreInfo StoreInfo { get; private set; } = new StoreInfo();

        /// <summary>
        /// Obtient ou définit le nom du caissier actuellement connecté.
        /// </summary>
        public static string CashierName { get; set; } = string.Empty;

        /// <summary>
        /// Initialise le gestionnaire de session. Cette méthode est le point d'entrée
        /// pour toute la configuration de l'application. Elle doit être appelée une seule fois
        /// au démarrage.
        /// </summary>
        public static void Initialize()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Lier la section StoreInfo à une nouvelle instance de StoreInfo
            var storeInfo = new StoreInfo();
            configuration.GetSection("StoreInfo").Bind(storeInfo);

            StoreInfo = storeInfo;
        }
    }
}