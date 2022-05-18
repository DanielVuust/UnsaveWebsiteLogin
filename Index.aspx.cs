using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnsaveWebsiteLogin
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void TryLogin(object sender, EventArgs e)
        {
            SigninManager signinManager = new SigninManager();
            string user = signinManager.login(UsernameInput.Text, PasswordInput.Text);
            if (user !=null)
            {
                LoginInfo.Text = $"Login Succesfull: Welcome {user}";
            }
            else
            {
                LoginInfo.Text = "Login Not Succesfull";
            }
        }
    }
}