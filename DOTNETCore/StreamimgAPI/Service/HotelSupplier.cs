using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace StreamingAPI.Service
{
    public class HotelSupplier
    {
        public SearchResult Search(SearchCriteria criteria)
        {   
            var content = File.ReadAllText("~/App_Data/SearchResult.json");
            return JsonConvert.DeserializeObject<SearchResult>(content);
        }
    }
}