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

            for (int i = 0; i < 15; i++)
            {
                try
                {
                    var document = collection.FindOneAndUpdate(
                        Builders<BsonDocument>.Filter.Eq("_id", sessionId + "_" + i.ToString()),
                        Builders<BsonDocument>.Update.Set("data", "read"));
                    var searchres = BsonSerializer.Deserialize<SearchResult>(document["data"].AsBsonDocument);
                    op.Add(searchres);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }            
            return op;
        }
    }
}