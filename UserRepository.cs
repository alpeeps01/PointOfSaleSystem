using MongoDB.Driver;

namespace PointOfSaleSystem
{
    public class UserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository(MongoDBConnection dbConnection)
        {
            _users = dbConnection.GetCollection("users");
        }

        public User GetUserByUsername(string username)
        {
            return _users.Find(user => user.Username == username).FirstOrDefault();
        }

        public bool VerifyPassword(User user, string password)
        {
            return user.Password == password;
        }
    }
}
