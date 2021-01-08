using JewleryAPI.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewleryAPI.service
{
    public interface IUserService
    {
        public User Authenticate(string username, string password);
    }
    public class UserService : IUserService
    {
        private JweleryDBContex jdbContext;
        public UserService(JweleryDBContex context)
        {
            jdbContext = context;
        }
        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = jdbContext.User.SingleOrDefault(x => x.Name  == username);
            if (user.Password != password)
                return null;
            return user;
        }
    }
}
