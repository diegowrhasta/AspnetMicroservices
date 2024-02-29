namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string Username { get; set; } = string.Empty;
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Price * item.Quantity;
                }

                return totalPrice;
            }
        }

        public ShoppingCart()
        {

        }

        public ShoppingCart(string userName)
        {
            Username = userName;
        }
    }
}
