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
    public partial class Orders : System.Web.UI.Page
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

                if(txtName.Text.Trim() != "")
                {
                    SqlParameter para = new SqlParameter("@Fullname", txtName.Text);
                    cmd.Parameters.Add(para);
                    txtName.Text = "";
                    panelTable.Visible = true;
                }
                ddacConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                searchResult.DataSource = reader;
                searchResult.DataBind();
                ddacConnection.Close();
            }
        }
    }
}