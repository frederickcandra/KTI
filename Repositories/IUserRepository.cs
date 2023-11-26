using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public interface IUserRepository 
    {
        UserModel? GetByUsernameAndPassword(string Username, string Password);
        UserModel? GetByGoogleId(string GoogleId);
    }
}