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
    public partial class ManageOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panelTable.Visible = false;
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
            using (SqlConnection ddacConnection = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ddacConnection;
                cmd.CommandText = "dbo.SearchOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                if (txtName.Text.Trim() != null)
                {
                    SqlParameter para = new SqlParameter("@Fullname", txtName.Text);
                    cmd.Parameters.Add(para);
                    txtName.Enabled = false;
                    panelTable.Visible = true;
                }
                ddacConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                searchResult.DataSource = reader;
                searchResult.DataBind();
                ddacConnection.Close();
            }
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;" +
                "Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;" +
                "Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=" +
                "False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "select count (*) from dbo.Orders where Fullname= '" + txtName.Text + "'";

            SqlCommand cmd = new SqlCommand(query, ddacConnection);

            int check = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (check == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('User may not be exist anymore!');</script>");
                txtName.Enabled = true;
            }
            else
            {
                string query3 = "update dbo.Orders set Status='" + "Delivering" + "' where Fullname = '" + txtName.Text + "'";
                string query4 = "update dbo.Orders set Sendername='" + ddlDelivery.SelectedItem.ToString() + "' where Fullname = '" + txtName.Text + "'";
                SqlCommand cmd3 = new SqlCommand(query3, ddacConnection);
                SqlCommand cmd4 = new SqlCommand(query4, ddacConnection);

                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();

                ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('Saved changed!');window.location ='ManageOrders';",
                                true);
            }
            ddacConnection.Close();
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            panelTable.Visible = false;
            txtName.Enabled = true;
        }
    }
}