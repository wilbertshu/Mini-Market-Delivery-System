using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDAC_Assignment1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Homepage");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login");
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register");
        }
    }
}