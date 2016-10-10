using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace StreamingAPI.Service
{
    public class HotelSupplier
    {
        public SearchResult Search(SearchCriteria criteria)
        {   
            var content = File.ReadAllText(HostingEnvironment.MapPath("~/App_Data/SearchResult.json"));
            return JsonConvert.DeserializeObject<SearchResult>(content);
        }
    }
}