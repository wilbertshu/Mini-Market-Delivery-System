using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DDAC_Assignment1
{
    public partial class ManageUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelUser.Visible = false;
            PanelList.Visible = false;
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "select * from dbo.Users where Fullname= '" + txtName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                PanelUser.Visible = true;
                PanelList.Visible = false;
                txtFullname.Text = (reader["Fullname"].ToString());
                txtUser.Text = (reader["UserID"].ToString());
                txtMail.Text = (reader["Email"].ToString());
                txtPhone.Text = (reader["Userphone"].ToString());
                txtType.Text = (reader["Usertype"].ToString());
                txtAddress.Text = (reader["Userhome"].ToString());
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('Data record not found');",
                true);
                txtName.Text = "";
            }
            ddacConnection.Close();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "delete from dbo.Users where Fullname = '" + txtFullname.Text + "'";
            string query2 = "delete from dbo.Orders where Fullname = '" + txtFullname.Text + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            SqlCommand cmd2 = new SqlCommand(query2, ddacConnection);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('User has been Deleted!');window.location ='ManageUser';",
                                true);
            ddacConnection.Close();
        }
        protected void BtnList_Click(object sender, EventArgs e)
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
            using (SqlConnection ddacConnection = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ddacConnection;
                cmd.CommandText = "dbo.UserList";
                cmd.CommandType = CommandType.StoredProcedure;
                ddacConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                userList.DataSource = reader;
                userList.DataBind();
                PanelList.Visible = true;
                ddacConnection.Close();
            }
        }

    }
}