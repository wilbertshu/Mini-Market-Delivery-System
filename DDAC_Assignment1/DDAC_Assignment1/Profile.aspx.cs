using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DDAC_Assignment1
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();

            if (Session["uname"] != null)
            {
                txtUser.Text = Session["uname"].ToString();
                string query = "select * from dbo.Users where UserID='" + txtUser.Text + "'";
                SqlCommand cmd = new SqlCommand(query, ddacConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = (reader["Fullname"].ToString());
                    txtUser.Text = (reader["UserID"].ToString());
                    txtMail.Text = (reader["Email"].ToString());
                    txtPhone.Text = (reader["Userphone"].ToString());
                    txtAddress.Text = (reader["Userhome"].ToString());
                }
                Session["address"] = txtAddress.Text;
                Session["phone"] = txtPhone.Text;
                Session["name"] = txtName.Text;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('Data record not found');window.location ='Homepage';",
                true);
            }
            ddacConnection.Close();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "update dbo.Users set Userpass='" + txtChange2.Text + "' where UserID = '" + txtUser.Text + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
            "alert",
            "alert('Saved Changes! Please log in again.');window.location ='Login';",
            true);
            Session.Abandon();
            ddacConnection.Close();
        }
    }
}