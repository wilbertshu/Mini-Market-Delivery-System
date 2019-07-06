using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DDAC_Assignment1
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();

            string query = "select count(*) from dbo.Users where UserID='" + "Admin" + "'";
            SqlCommand command = new SqlCommand(query, ddacConnection);
            int check = Convert.ToInt32(command.ExecuteScalar().ToString());
            if(check == 0)
            {
                string query2 = "insert into dbo.Users (Fullname, UserID, Email, Userpass, Usertype) values (@Fullname,@uname,@email,@pass,@type)";
                SqlCommand cmd1 = new SqlCommand(query2, ddacConnection);
                cmd1.Parameters.AddWithValue("@Fullname", "Admin");
                cmd1.Parameters.AddWithValue("@uname", "Admin");
                cmd1.Parameters.AddWithValue("@email", "Admin@Admin.com");
                cmd1.Parameters.AddWithValue("@pass", "Admin123");
                cmd1.Parameters.AddWithValue("@type", "Admin");
                cmd1.ExecuteNonQuery();
            }
            ddacConnection.Close();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                ddacConnection.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from dbo.Users where UserID ='" + txtUser.Text + "' and Userpass ='" + txtPass.Text + "'", ddacConnection);
                int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (count > 0)
                {
                    SqlCommand cmdType = new SqlCommand("select Usertype from dbo.Users where UserID = '" + txtUser.Text + "'", ddacConnection);
                    string uType = cmdType.ExecuteScalar().ToString().Replace(" ", "");
                    Session["uType"] = uType;
                    Session["uname"] = txtUser.Text;

                    if (Session["uname"].ToString() == "Delivery")
                    {
                        Response.Redirect("Homepage");
                    }
                    else if (Session["uname"].ToString() == "Admin")
                    {
                        Response.Redirect("Homepage");
                    }
                    else
                    {
                        Response.Redirect("Profile");
                    }
                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Fail Login!');window.location ='Login';", true);
                }
                ddacConnection.Close();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage");
        }
    }
}