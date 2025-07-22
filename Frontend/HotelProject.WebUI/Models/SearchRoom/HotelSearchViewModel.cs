namespace RapidApiHotelProject.Models
{
    public class HotelSearchViewModel
    {
        public string City { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public int Adults { get; set; }
        public string ChildrenAge { get; set; } // Örn: "1,17"
        public int RoomQty { get; set; }
    }

}
