using MongoDB.Driver;

namespace PointOfSaleSystem
{
    public class MongoDBConnection
    {
        private readonly IMongoDatabase _database;

        public MongoDBConnection(string connectionString, string databaseName)
        {
            var client = new MongoClient("mongodb://localhost:27017/"); 
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<User>GetCollection(string collectionName)
        {
            return _database.GetCollection<User>(collectionName);
        }
    }
}
