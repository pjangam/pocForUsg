using System.Collections.Generic;

namespace StreamingAPI
{
    public class SearchResult
    {
        public List<Hotel> Hotels { get; set; }
        public Status Status { get; set; }
    }
}