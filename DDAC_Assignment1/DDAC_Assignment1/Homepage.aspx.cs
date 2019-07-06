using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Web;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Auth;

namespace DDAC_Assignment1
{
    public partial class Homepage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"] != null)
            {
                lblUtype.Visible = true;
                lblUtype.Text = ("Welcome Back, ") + Session["uType"].ToString();
                lblUname.Text = Session["uname"].ToString();
            }

        }
    }
}