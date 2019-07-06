using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DDAC_Assignment1
{
    public partial class BuyItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = Session["name"].ToString();
            lblAddress.Text = Session["address"].ToString();
            lblPhone.Text = Session["phone"].ToString();
            lblUname.Text = Session["uname"].ToString();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (ddlItems.SelectedValue == "Milk")
            {
                panelMilk.Visible = true;
                panelButter.Visible = false;
                panelBread.Visible = false;
                panelDrink.Visible = false;
                panelRice.Visible = false;
                panelSnack.Visible = false;
            }
            else if (ddlItems.SelectedValue == "Butter")
            {
                panelButter.Visible = true;
                panelMilk.Visible = false;
                panelBread.Visible = false;
                panelDrink.Visible = false;
                panelRice.Visible = false;
                panelSnack.Visible = false;
            }
            else if (ddlItems.SelectedValue == "Bread")
            {
                panelBread.Visible = true;
                panelButter.Visible = false;
                panelMilk.Visible = false;
                panelDrink.Visible = false;
                panelRice.Visible = false;
                panelSnack.Visible = false;

            }
            else if (ddlItems.SelectedValue == "Drink")
            {
                panelDrink.Visible = true;
                panelRice.Visible = false;
                panelSnack.Visible = false;
                panelBread.Visible = false;
                panelButter.Visible = false;
                panelMilk.Visible = false;
            }
            else if (ddlItems.SelectedValue == "Rice")
            {
                panelRice.Visible = true;
                panelSnack.Visible = false;
                panelBread.Visible = false;
                panelButter.Visible = false;
                panelMilk.Visible = false;
                panelDrink.Visible = false;
            }
            else if (ddlItems.SelectedValue == "Snack")
            {
                panelSnack.Visible = true;
                panelRice.Visible = false;
                panelBread.Visible = false;
                panelButter.Visible = false;
                panelMilk.Visible = false;
                panelDrink.Visible = false;
            }
            else
            {
                Response.Redirect("BuyItems");
            }
        }

        protected void btnMilk_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "select count(*) from dbo.Orders where Items='" + "Milk" + "'";
            SqlCommand command = new SqlCommand(query, ddacConnection);

            int check = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (check > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('You already have this in your cart');window.location ='BuyItems';", true);
            }
            else
            {
                int quantity, price, total;
                quantity = int.Parse(txtMilk.Text);
                price = 12;
                total = price * quantity;

                String totalMilk = total.ToString();
                lblMilk.Text = totalMilk;

                SqlCommand cmd = new SqlCommand("EXEC dbo.Checkout @Fullname,@uname,@item,@status,@address,@price,@quantity,@phone", ddacConnection);
                cmd.Parameters.AddWithValue("@Fullname", lblName.Text);
                cmd.Parameters.AddWithValue("@uname", lblUname.Text);
                cmd.Parameters.AddWithValue("@item", "Milk");
                cmd.Parameters.AddWithValue("@status", "Temporary");
                cmd.Parameters.AddWithValue("@address", lblAddress.Text);
                cmd.Parameters.AddWithValue("@phone", lblPhone.Text);
                cmd.Parameters.AddWithValue("@quantity", txtMilk.Text);
                cmd.Parameters.AddWithValue("@price", lblMilk.Text);

                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Item has been added!');", true);
                ddacConnection.Close();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "delete from dbo.Orders where Fullname = '" + lblName.Text + "' and Items='" + "Milk" + "' and Status='" + "Temporary" + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('Item has been reset!');", true);
            ddacConnection.Close();
        }

        protected void btnButter_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "select count(*) from dbo.Orders where Items='" + "Butter" + "'";
            SqlCommand command = new SqlCommand(query, ddacConnection);

            int check = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (check > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('You already have this in your cart');window.location ='BuyItems';", true);
            }
            else
            {
                int quantity, price, total;
                quantity = int.Parse(txtButter.Text);
                price = 7;
                total = price * quantity;

                String totalButter = total.ToString();
                lblButter.Text = totalButter;

                SqlCommand cmd = new SqlCommand("EXEC dbo.Checkout @Fullname,@uname,@item,@status,@address,@price,@quantity,@phone", ddacConnection);
                cmd.Parameters.AddWithValue("@Fullname", lblName.Text);
                cmd.Parameters.AddWithValue("@uname", lblUname.Text);
                cmd.Parameters.AddWithValue("@item", "Butter");
                cmd.Parameters.AddWithValue("@status", "Temporary");
                cmd.Parameters.AddWithValue("@address", lblAddress.Text);
                cmd.Parameters.AddWithValue("@phone", lblPhone.Text);
                cmd.Parameters.AddWithValue("@quantity", txtButter.Text);
                cmd.Parameters.AddWithValue("@price", lblButter.Text);

                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Item has been added!');", true);
                ddacConnection.Close();
            }
        }

        protected void btnCancel2_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "delete from dbo.Orders where Fullname = '" + lblName.Text + "' and Items='" + "Butter" + "' and Status='" + "Temporary" + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('Item has been reset!');", true);
            ddacConnection.Close();
        }

        protected void btnBread_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "select count(*) from dbo.Orders where Items='" + "Bread" + "'";
            SqlCommand command = new SqlCommand(query, ddacConnection);

            int check = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (check > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('You already have this in your cart');window.location ='BuyItems';", true);
            }
            else
            {
                int quantity, price, total;
                quantity = int.Parse(txtBread.Text);
                price = 4;
                total = price * quantity;

                String totalBread = total.ToString();
                lblBread.Text = totalBread;

                SqlCommand cmd = new SqlCommand("EXEC dbo.Checkout @Fullname,@uname,@item,@status,@address,@price,@quantity,@phone", ddacConnection);
                cmd.Parameters.AddWithValue("@Fullname", lblName.Text);
                cmd.Parameters.AddWithValue("@uname", lblUname.Text);
                cmd.Parameters.AddWithValue("@item", "Bread");
                cmd.Parameters.AddWithValue("@status", "Temporary");
                cmd.Parameters.AddWithValue("@address", lblAddress.Text);
                cmd.Parameters.AddWithValue("@phone", lblPhone.Text);
                cmd.Parameters.AddWithValue("@quantity", txtBread.Text);
                cmd.Parameters.AddWithValue("@price", lblBread.Text);

                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Item has been added!');", true);
                ddacConnection.Close();
            }
        }

        protected void btnCancel3_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "delete from dbo.Orders where Fullname = '" + lblName.Text + "' and Items='" + "Bread" + "' and Status='" + "Temporary" + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('Item has been reset!');", true);
            ddacConnection.Close();
        }

        protected void btnRice_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "select count(*) from dbo.Orders where Items='" + "Rice" + "'";
            SqlCommand command = new SqlCommand(query, ddacConnection);

            int check = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (check > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('You already have this in your cart');window.location ='BuyItems';", true);
            }
            else
            {
                int quantity, price, total;
                quantity = int.Parse(txtRice.Text);
                price = 18;
                total = price * quantity;

                String totalRice = total.ToString();
                lblRice.Text = totalRice;

                SqlCommand cmd = new SqlCommand("EXEC dbo.Checkout @Fullname,@uname,@item,@status,@address,@price,@quantity,@phone", ddacConnection);
                cmd.Parameters.AddWithValue("@Fullname", lblName.Text);
                cmd.Parameters.AddWithValue("@uname", lblUname.Text);
                cmd.Parameters.AddWithValue("@item", "Rice");
                cmd.Parameters.AddWithValue("@status", "Temporary");
                cmd.Parameters.AddWithValue("@address", lblAddress.Text);
                cmd.Parameters.AddWithValue("@phone", lblPhone.Text);
                cmd.Parameters.AddWithValue("@quantity", txtRice.Text);
                cmd.Parameters.AddWithValue("@price", lblRice.Text);

                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Item has been added!');", true);
                ddacConnection.Close();
            }
        }

        protected void btnCancel4_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "delete from dbo.Orders where Fullname = '" + lblName.Text + "' and Items='" + "Rice" + "' and Status='" + "Temporary" + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('Item has been reset!');", true);
            ddacConnection.Close();
        }

        protected void btnSnack_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "select count(*) from dbo.Orders where Items='" + "Snack" + "'";
            SqlCommand command = new SqlCommand(query, ddacConnection);

            int check = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (check > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('You already have this in your cart');window.location ='BuyItems';", true);
            }
            else
            {
                int quantity, price, total;
                quantity = int.Parse(txtSnack.Text);
                price = 5;
                total = price * quantity;

                String totalSnack = total.ToString();
                lblSnack.Text = totalSnack;

                SqlCommand cmd = new SqlCommand("EXEC dbo.Checkout @Fullname,@uname,@item,@status,@address,@price,@quantity,@phone", ddacConnection);
                cmd.Parameters.AddWithValue("@Fullname", lblName.Text);
                cmd.Parameters.AddWithValue("@uname", lblUname.Text);
                cmd.Parameters.AddWithValue("@item", "Snack");
                cmd.Parameters.AddWithValue("@status", "Temporary");
                cmd.Parameters.AddWithValue("@address", lblAddress.Text);
                cmd.Parameters.AddWithValue("@phone", lblPhone.Text);
                cmd.Parameters.AddWithValue("@quantity", txtSnack.Text);
                cmd.Parameters.AddWithValue("@price", lblSnack.Text);

                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Item has been added!');", true);
                ddacConnection.Close();
            }
        }

        protected void btnCancel5_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "delete from dbo.Orders where Fullname = '" + lblName.Text + "' and Items='" + "Snack" + "' and Status='" + "Temporary" + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('Item has been reset!');", true);
            ddacConnection.Close();
        }

        protected void btnDrink_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "select count(*) from dbo.Orders where Items='" + "Drink" + "'";
            SqlCommand command = new SqlCommand(query, ddacConnection);

            int check = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (check > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('You already have this in your cart');window.location ='BuyItems';", true);
            }
            else
            {
                int quantity, price, total;
                quantity = int.Parse(txtDrink.Text);
                price = 8;
                total = price * quantity;

                String totalDrink = total.ToString();
                lblDrink.Text = totalDrink;

                SqlCommand cmd = new SqlCommand("EXEC dbo.Checkout @Fullname,@uname,@item,@status,@address,@price,@quantity,@phone", ddacConnection);
                cmd.Parameters.AddWithValue("@Fullname", lblName.Text);
                cmd.Parameters.AddWithValue("@uname", lblUname.Text);
                cmd.Parameters.AddWithValue("@item", "Drink");
                cmd.Parameters.AddWithValue("@status", "Temporary");
                cmd.Parameters.AddWithValue("@address", lblAddress.Text);
                cmd.Parameters.AddWithValue("@phone", lblPhone.Text);
                cmd.Parameters.AddWithValue("@quantity", txtDrink.Text);
                cmd.Parameters.AddWithValue("@price", lblDrink.Text);

                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "alert",
                    "alert('Item has been added!');", true);
                ddacConnection.Close();
            }
        }

        protected void btnCancel6_Click(object sender, EventArgs e)
        {
            SqlConnection ddacConnection = new SqlConnection("Server=tcp:wilbertddac.database.windows.net,1433;Initial Catalog=DDAC_Assignment;Persist Security Info=False;User ID=wilbertddac;Password=Wilbertcool10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            ddacConnection.Open();
            string query = "delete from dbo.Orders where Fullname = '" + lblName.Text + "' and Items='" + "Drink" + "' and Status='" + "Temporary" + "'";
            SqlCommand cmd = new SqlCommand(query, ddacConnection);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                                "alert",
                                "alert('Item has been reset!');", true);
            ddacConnection.Close();
        }
    }
}