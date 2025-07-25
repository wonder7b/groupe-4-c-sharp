using Microsoft.EntityFrameworkCore;

namespace fa.Models;

/// <summary>
/// Représente un produit commercialisable.
/// L'attribut [Index] garantit que le code produit est unique dans la base de données.
/// </summary>
[Index(nameof(Code), IsUnique = true)]
public class Product
{
    public int Id { get; set; }
    
    /// <summary>
    /// Code unique du produit (ex: "00123").
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Nom d'affichage du produit.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Prix de vente unitaire.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Catégorie de TVA applicable au produit.
    /// </summary>
    public TaxCategory TaxCategory { get; set; }

    public override string ToString()
    {
        return Name; // Utilisé pour l'affichage dans les listes.
    }
}
