namespace practiceApplication.Models

{
   
    public class Wishlist
    {
        
        public int ClientID { get; set; }
        public int ProductID { get; set; }

        public string? Note { get; set; }
        public string? Tags { get; set; }
    }
}