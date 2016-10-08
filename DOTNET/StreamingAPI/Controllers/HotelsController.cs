using Newtonsoft.Json;
using StreamingAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StreamingAPI
{
    [RoutePrefix("api/hotels")]

    public class HotelsController : Controller
    {
        [Route(@"search/init")]
        public string SearchInit(SearchCriteria criteria)
        {
            var sessionId = Guid.NewGuid().ToString();
            new HotelService().InitSearch(sessionId, criteria);
            return sessionId;
        }

        [Route(@"search/{sessionId}/results")]
        public async Task<SearchResult> SearchResult(string sessionId)
        {
            return await new HotelService().GetResult(sessionId);
        }

        [Route(@"DumpData")]
        public void DumpData()
        {
            var searchres = new SearchResult
            {
                Hotels = new List<Hotel>
                {
                 new Hotel
                 {
                     Id="1",
                     Name="fddkjfnal",
                     Price=546.354m,
                     Rooms=new List<Room>
                     {
                         new Room
                         {
                             Id ="r",
                             Name ="fwefewf",
                             Price =78.456m,
                         },
                          new Room
                         {
                             Id ="rrf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rerfewadf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rewfas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rserfasdca",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rasdas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3eq",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3r",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="r4tsfdfs",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rkgyk",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rgaew4g",
                             Name ="fwefewf",
                             Price =78.456m,
                         } ,new Room
                         {
                             Id ="reagr",
                             Name ="fwefewf",
                             Price =78.456m,
                         }

                     } },
                     new Hotel
                 {
                     Id="2",
                     Name="fddkjfnal",
                     Price=546.354m,
                     Rooms=new List<Room>
                     {
                         new Room
                         {
                             Id ="r",
                             Name ="fwefewf",
                             Price =78.456m,
                         },
                          new Room
                         {
                             Id ="rrf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rerfewadf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rewfas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rserfasdca",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rasdas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3eq",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3r",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="r4tsfdfs",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rkgyk",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rgaew4g",
                             Name ="fwefewf",
                             Price =78.456m,
                         } ,new Room
                         {
                             Id ="reagr",
                             Name ="fwefewf",
                             Price =78.456m,
                         }

                     } },
                     new Hotel
                 {
                     Id="3",
                     Name="fddkjfnal",
                     Price=546.354m,
                     Rooms=new List<Room>
                     {
                         new Room
                         {
                             Id ="r",
                             Name ="fwefewf",
                             Price =78.456m,
                         },
                          new Room
                         {
                             Id ="rrf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rerfewadf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rewfas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rserfasdca",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rasdas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3eq",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3r",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="r4tsfdfs",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rkgyk",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rgaew4g",
                             Name ="fwefewf",
                             Price =78.456m,
                         } ,new Room
                         {
                             Id ="reagr",
                             Name ="fwefewf",
                             Price =78.456m,
                         }

                     } },
                     new Hotel
                 {
                     Id="4",
                     Name="fddkjfnal",
                     Price=546.354m,
                     Rooms=new List<Room>
                     {
                         new Room
                         {
                             Id ="r",
                             Name ="fwefewf",
                             Price =78.456m,
                         },
                          new Room
                         {
                             Id ="rrf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rerfewadf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rewfas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rserfasdca",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rasdas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3eq",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3r",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="r4tsfdfs",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rkgyk",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rgaew4g",
                             Name ="fwefewf",
                             Price =78.456m,
                         } ,new Room
                         {
                             Id ="reagr",
                             Name ="fwefewf",
                             Price =78.456m,
                         }

                     } },
                     new Hotel
                 {
                     Id="5",
                     Name="fddkjfnal",
                     Price=546.354m,
                     Rooms=new List<Room>
                     {
                         new Room
                         {
                             Id ="r",
                             Name ="fwefewf",
                             Price =78.456m,
                         },
                          new Room
                         {
                             Id ="rrf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rerfewadf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rewfas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rserfasdca",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rasdas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3eq",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3r",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="r4tsfdfs",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rkgyk",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rgaew4g",
                             Name ="fwefewf",
                             Price =78.456m,
                         } ,new Room
                         {
                             Id ="reagr",
                             Name ="fwefewf",
                             Price =78.456m,
                         }

                     } },
                     new Hotel
                 {
                     Id="6",
                     Name="fddkjfnal",
                     Price=546.354m,
                     Rooms=new List<Room>
                     {
                         new Room
                         {
                             Id ="r",
                             Name ="fwefewf",
                             Price =78.456m,
                         },
                          new Room
                         {
                             Id ="rrf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rerfewadf",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rewfas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rserfasdca",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rasdas",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3eq",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rw3r",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="r4tsfdfs",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rkgyk",
                             Name ="fwefewf",
                             Price =78.456m,
                         }, new Room
                         {
                             Id ="rgaew4g",
                             Name ="fwefewf",
                             Price =78.456m,
                         } ,new Room
                         {
                             Id ="reagr",
                             Name ="fwefewf",
                             Price =78.456m,
                         }

                     }
                    }
                }
            };
            var content = JsonConvert.SerializeObject(searchres);
            System.IO.File.WriteAllText("~/App_Data/SearchResult.json", content);

        }
    }
}
