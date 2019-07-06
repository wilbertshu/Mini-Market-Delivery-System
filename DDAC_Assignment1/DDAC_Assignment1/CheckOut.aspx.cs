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
    public partial class CheckOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
            using (SqlConnection ddacConnection = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ddacConnection;
                cmd.CommandText = "dbo.SearchOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                if (lblName.Text.Trim() != "")
                {
                    SqlParameter para = new SqlParameter("@Fullname", lblName.Text);
                    cmd.Parameters.Add(para);
                    lblName.Text = "";
                }
                ddacConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                listCheckout.DataSource = reader;
                listCheckout.DataBind();
                ddacConnection.Close();
            }
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            lblName.Text = Session["name"].ToString();
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "update dbo.Orders set Status='" + "Confirmed" + "' where Fullname = '" + lblName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
            "alert",
            "alert('Thank you for purchasing! Please wait until your item is delivered');window.location ='Homepage';",
            true);
            ddacConnection.Close();
        }
    }
}