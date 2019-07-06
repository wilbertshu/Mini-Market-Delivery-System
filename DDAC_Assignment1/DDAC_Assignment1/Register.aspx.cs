using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DDAC_Assignment1
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Attributes.Add("maxlength", "30");
            txtMail.Attributes.Add("maxlength", "50");
            txtPass.Attributes.Add("maxlength", "30");
            txtPhone.Attributes.Add("maxlength", "30");
            txtUser.Attributes.Add("maxlength", "20");
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                ddacConnection.Open();
                
                string query = "select count(*) from dbo.Users where UserID='" + txtUser.Text + "'";
                string query2 = "select count(*) from dbo.Users where Email='" + txtMail.Text + "'";
                SqlCommand command = new SqlCommand(query, ddacConnection);
                SqlCommand command2 = new SqlCommand(query2, ddacConnection);
                int check = Convert.ToInt32(command.ExecuteScalar().ToString());
                int check2 = Convert.ToInt32(command2.ExecuteScalar().ToString());
                if (check > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('User ID exist, please re-type new one!');window.location ='Register';", true);
                }
                if (check2 > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Email exist, please re-type new one!');window.location ='Register';", true);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("EXEC dbo.InsertData @Fullname,@uname,@email,@phone,@pass,@type,@address", ddacConnection);
                    cmd.Parameters.AddWithValue("@Fullname", txtName.Text);
                    cmd.Parameters.AddWithValue("@uname", txtUser.Text);
                    cmd.Parameters.AddWithValue("@email", txtMail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@type", ddlUserType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                    cmd.ExecuteNonQuery();
                    ddacConnection.Close();
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Registration Success!');window.location ='Login';", true);
                }
            }
        }


        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            RequiredFieldValidator1.Enabled = false;
            RequiredFieldValidator2.Enabled = false;
            RequiredFieldValidator3.Enabled = false;
            RequiredFieldValidator4.Enabled = false;
            RequiredFieldValidator5.Enabled = false;
            Response.Redirect("Homepage");
        }
    }
}