namespace HotelProject.WebUI.Models.SearchRoom
{
    public class ResultRoomListExampleData
    {

     
            public int hotel_id { get; set; }
            public string accessibilityLabel { get; set; }
            public Property1 property { get; set; }
      
        public class Property1
        {
            public int propertyClass { get; set; }
            public int reviewCount { get; set; }
            public int mainPhotoId { get; set; }
            public string[] blockIds { get; set; }
            public int optOutFromGalleryChanges { get; set; }
            public float latitude { get; set; }
            public bool isPreferred { get; set; }
            public int accuratePropertyClass { get; set; }
            public int position { get; set; }
            public int qualityClass { get; set; }
            public string[] photoUrls { get; set; }
            public Checkin checkin { get; set; }
            public float longitude { get; set; }
            public int ufi { get; set; }
            public string currency { get; set; }
            public int id { get; set; }
            public string wishlistName { get; set; }
            public string reviewScore { get; set; }
            public string countryCode { get; set; }
            public Checkout checkout { get; set; }
            public Pricebreakdown priceBreakdown { get; set; }
            public string name { get; set; }
            public int rankingPosition { get; set; }
            public string checkinDate { get; set; }
            public string checkoutDate { get; set; }
            public string reviewScoreWord { get; set; }
            public bool isFirstPage { get; set; }
            public bool isPreferredPlus { get; set; }
        }

        public class Checkin
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }

        public class Checkout
        {
            public string untilTime { get; set; }
            public string fromTime { get; set; }
        }

        public class Pricebreakdown
        {
            public Grossprice grossPrice { get; set; }
            public object[] taxExceptions { get; set; }
            public object excludedPrice { get; set; }
            public Benefitbadge[] benefitBadges { get; set; }
            public Strikethroughprice strikethroughPrice { get; set; }
        }

        public class Grossprice
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Strikethroughprice
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Benefitbadge
        {
            public string text { get; set; }
            public string explanation { get; set; }
            public string identifier { get; set; }
            public string variant { get; set; }
        }

    }
}
