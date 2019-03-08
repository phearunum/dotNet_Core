using dotNet.Models;
using dotNet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet.Repository
{
    public class UserRepository : IUser
    {

        private DBContext db;
        public UserRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<User> GetUsers => db.User;

        public void Add(User _User)
        {
            
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
