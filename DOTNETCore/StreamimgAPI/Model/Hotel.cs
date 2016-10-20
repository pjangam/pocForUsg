using System.Collections.Generic;

namespace StreamingAPI
{
    public class Hotel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Id { get; set; }
        public List<Room> Rooms { get; set; }
    }
}