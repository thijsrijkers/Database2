using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Database2
{
    public class NoSQL
    {
        public void NOSQL_Test(int counter)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var dbClient = new MongoClient("mongodb://localhost:27017");
            var db = dbClient.GetDatabase("Database2_mongodb");
            var profile = db.GetCollection<BsonDocument>("profile");
            var subscription = db.GetCollection<BsonDocument>("subscription");
            var user = db.GetCollection<BsonDocument>("user");

            for (int i = 0; i < counter; i++)
            {
                var documentIn = new BsonDocument
                {
                    {"Name", "testuser"}
                };

                user.InsertOne(documentIn);
            }
            var filter = Builders<BsonDocument>.Filter.Eq("Name", "testuser");
            var update = Builders<BsonDocument>.Update.Set("Name", "adaptedTestUser");
            user.UpdateMany(filter, update);

            var documentsList = user.Find(new BsonDocument()).ToList();
            foreach (BsonDocument doc in documentsList)
            {
                Console.WriteLine(doc.ToString());
            }

            var deleteFilter = Builders<BsonDocument>.Filter.Eq("Name", "adaptedTestUser");
            user.DeleteMany(deleteFilter);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine(ts);
        }
    }
}
