namespace StreamingAPI
{
    public class SearchCriteria
    {
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string Location { get; set; }
        public int Rooms { get; set; }
        public int Guests { get; set; }
    }
}