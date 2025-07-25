// Models/StoreInfo.cs
namespace fa.Models
{
    /// <summary>
    /// Représente les informations de configuration du magasin.
    /// </summary>
    public class StoreInfo
    {
        public string Name { get; set; } = "Nom non défini";
        public string Address { get; set; } = "Adresse non définie";
        public string Email { get; set; } = "Email non défini";
        public string ReceiptFooter { get; set; } = "Merci !";
    }
}
