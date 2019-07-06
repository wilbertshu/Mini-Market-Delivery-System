using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DDAC_Assignment1
{
    public partial class DeliveryOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUname.Text = Session["uname"].ToString();
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
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
                    panelCheck.Visible = false;
                    panelList.Visible = true;
                }
                ddacConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                deliveryOrder.DataSource = reader;
                deliveryOrder.DataBind();
                ddacConnection.Close();
            }
        }
    }
}