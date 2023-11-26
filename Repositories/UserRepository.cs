using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class UserRepository : IUserRepository
    {   
        private List<UserModel> users = new List<UserModel>{
            new UserModel{Id=123,Name="Candra", Password="rahasia",
            FavoritColor="blue", Role="admin", GoogleId="1198877"}
        };
        public UserModel? GetByGoogleId(string GoogleId)
        {
            throw new NotImplementedException();
        }

        public UserModel? GetByUsernameAndPassword(string username, string password)
        {
            var user = users.SingleOrDefault(u=>u.Name == username && password =="rahasia");
            return user;
        }
    }
}