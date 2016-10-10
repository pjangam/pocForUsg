using StreamingAPI.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StreamingAPI.Service
{
    public class HotelService
    {
        public void InitSearch(string sessionId, SearchCriteria criteria)
        {
            Parallel.For(0, 15, async (i) =>
            {
                await Task.Yield();
                var randomizer = new Random();
                await (Task.Delay(randomizer.Next(10000, 15000)));
                var supplier = new HotelSupplier();
                var result = supplier.Search(criteria);
                var db = new SearchDB();
                await db.StoreSearchResult(sessionId, i, result);
            });
        }
        public async Task<SearchResult> GetResult(string sessionId)
        {
            bool isComplete = false;
            var final = new SearchResult() { Hotels = new List<Hotel>() };
            var db = new SearchDB();
            var res = await db.GetResult(sessionId);
            if (res.Count == 15) { isComplete = true; }

            foreach (var result in res)
            {
                final.Hotels.AddRange(result.Hotels);
                //foreach (var hotel in result.Hotels)
                //{

                //}
            }

            final.Status = new Status { MoreResults = !isComplete };
            return final;
        }
    }
}