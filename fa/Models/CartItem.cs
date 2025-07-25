using fa.Models;

namespace fa.Models;

public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice => Product.Price * Quantity;
}
