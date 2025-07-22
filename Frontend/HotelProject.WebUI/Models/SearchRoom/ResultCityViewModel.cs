namespace HotelProject.WebUI.Models.SearchRoom
{
    public class ResultCityViewModel
    {

        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public Datum[] data { get; set; }

        public class Datum
        {
            public string dest_id { get; set; }
            public string image_url { get; set; }
            public int hotels { get; set; }
            public string label { get; set; }
            public string name { get; set; }

        }

    }
}
