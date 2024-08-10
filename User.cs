using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PointOfSaleSystem
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }   
    }
}
