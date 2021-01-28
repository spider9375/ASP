namespace BlazorApp1.Data.Models
{
    public class CartModel
    {
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string HotelName { get; set; }
        public string City { get; set; }
        public string RoomDetails { get; set; }
        public decimal Price { get; set; }
        public int Nights { get; set; }
    }
}
