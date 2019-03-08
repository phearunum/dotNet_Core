using dotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet.Services
{
    interface IUser
    {
        IEnumerable<User> GetUsers { get; }
        User GetUser(int id);
        void Add(User _User);
        void Remove(int id);
      
    }
}
