using fa.Models;

namespace fa.Models;

public class CartItem
{
    public Product Produit { get; set; }
    public int Quantite { get; set; }
    public decimal PrixTotal => Produit.Prix * Quantite;
}
