using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ShoppingWebsite
{
    public partial class songspage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string title = Request.QueryString["title"];
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("songspage", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@title", title);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            conn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // reading title from query string and storing in a session
            string SessionTitle = Request.QueryString["title"];
            //Session["Cart"] = SessionTitle;
            List<string> cartitems = new List<string>();
            if (Session["Cart"] != null)
            {
                cartitems = (List<string>)Session["Cart"];
            }
            else
            {
                cartitems = new List<string>();
            }

            cartitems.Add(SessionTitle);
            Session["Cart"] = cartitems;
            int a = cartitems.Count();

            Response.Write("Number of items added into cart is " + a);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("webpage.aspx");
        }

        protected void txtbtn3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }
    }
}