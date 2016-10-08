using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StreamingAPI.DB
{
    public class SearchDB
    {
        private IMongoClient _client;
        private IMongoDatabase _database;

        public SearchDB()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("hotels");

        }

        public async System.Threading.Tasks.Task<bool> StoreSearchResult(string sessionId, int CallId, SearchResult result)
        {
            var id = $"{sessionId}_{CallId.ToString()}";
            var document = new BsonDocument
            {
                { "_id", id },
                { "data", result.ToBsonDocument()}
            };
            var collection = _database.GetCollection<BsonDocument>("dotnet");
            await collection.InsertOneAsync(document);
            return true;
        }

        public async Task<List<SearchResult>> GetResult(string sessionId)
        {
            var op = new List<SearchResult>();
            var collection = _database.GetCollection<BsonDocument>("dotnet");
            var filter = new BsonDocument();
            var count = 0;
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        var searchres = BsonSerializer.Deserialize<SearchResult>(document["data"].AsBsonDocument);
                        op.Add(searchres);
                        count++;
                    }
                }
            }
            return op;
        }
    }
}