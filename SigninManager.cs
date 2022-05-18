using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnsaveWebsiteLogin
{
    public class SigninManager
    {
        public string login(string username, string password)
        {
            var userInfo = new UserInfo();
            return userInfo.GetUser(username, password);
        }
        
    }
}