namespace CoreMVC.Models
{
    public class CartModel
    {
        public string CartSessionId { get; set; }
        public List<CartItemModel> Items { get; set; }
    }

    public class CartItemModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
