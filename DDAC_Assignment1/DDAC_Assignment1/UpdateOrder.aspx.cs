using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDAC_Assignment1
{
    public partial class UpdateOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUname.Text = Session["uname"].ToString();
            string connectionStr = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
            using (SqlConnection ddacConnection = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ddacConnection;
                cmd.CommandText = "dbo.DeliveryOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                if (lblUname.Text.Trim() != null)
                {
                    SqlParameter para = new SqlParameter("@Sendername", lblUname.Text);
                    cmd.Parameters.Add(para);
                }
                ddacConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                updateOrder.DataSource = reader;
                updateOrder.DataBind();
                ddacConnection.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;" +
                "Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;" +
                "Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;" +
                "Connection Timeout=30;");
            ddacConnection.Open();
            string queryCheck = "select count (*) from dbo.Orders where Fullname= '" + txtName.Text + "'";
            SqlCommand command = new SqlCommand(queryCheck, ddacConnection);
            int check = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (check == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('Wrong User's name, Fail to Update!');</script>");
                txtName.Text = "";
            }
            else
            {
                string query = "delete from dbo.Orders where Fullname = '" + txtName.Text + "'";

                SqlCommand cmd = new SqlCommand(query, ddacConnection);

                cmd.ExecuteNonQuery();

                ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('Thank you for Ordering!');window.location ='Homepage';",
                                true);
            }
            ddacConnection.Close();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}