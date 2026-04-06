namespace practiceApplication.Models
{
    public class CartModel
    {
        public int ClientID { get; set; }
        public int Productid { get; set; }
        public string Productimage { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}