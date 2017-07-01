using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace ShoppingWebsite
{
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> titles = (List<string>)Session["Cart"];
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            foreach (string title in titles)
            {
                SqlCommand cmd = new SqlCommand("songspage", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", title);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Columns.Add("Title");
                //dt.Columns.Add("Name");
                //dt.Columns.Add("GName");
                //dt.Columns.Add("Description");
                //dt.Columns.Add("Price");
                //DataRow row = dt.NewRow();
                //while(dr.Read())
                //{
                //    row["Title"] = dr[0].ToString();
                //    row["Name"] = dr[1].ToString();
                //    row["GName"] = dr[2].ToString();
                //    row["Description"] = dr[3].ToString();
                //    row["Price"] = dr[4].ToString();
                //    dt.Rows.Add(row);
                //}
                //foreach(DataRow drow in dt.Rows)
                //{
                //    int num = 2;
                //    GridView1.Rows[num].Cells[0].Text = drow["Title"].ToString();
                //    GridView1.Rows[num].Cells[1].Text = drow["Name"].ToString();
                //    GridView1.Rows[num].Cells[2].Text = drow["GName"].ToString();
                //    GridView1.Rows[num].Cells[3].Text = drow["Description"].ToString();
                //    GridView1.Rows[num].Cells[4].Text = drow["Price"].ToString();
                //}

                while (dr.Read())
                {
                    Response.Write("<Table>");
                    Response.Write("<th>");
                    Response.Write("<tr>");
                    Response.Write("<td>" + dr["Title"].ToString() + "<td/>");
                    Response.Write("<td>" + dr["Name"].ToString() + "<td/>");
                    Response.Write("<td>" + dr["Name"].ToString() + "<td/>");
                    Response.Write("<td>" + dr["Description"].ToString() + "<td/>");
                    Response.Write("<td>" + dr["Price"].ToString() + "<td/>");
                    Response.Write("</tr>");
                    Response.Write("</th>");
                    Response.Write("</Table>");
                    Response.Write("<br/>" + "<br/>" + "<br/>" + "<br/>");
                }
                //Repeater1.DataSource = dr;
                //Repeater1.DataBind();
                conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            List<string> titles = (List<string>)Session["Cart"];
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            List<int> albumid = new List<int>();
            foreach (string title in titles)
            {
                SqlCommand cmd = new SqlCommand("select AlbumId from Album where Title = '" + title + "'", conn);
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                albumid.Add(a);
            }
            int count = albumid.Count;
            string datecreated = System.DateTime.Now.ToString();
            foreach (int id in albumid)
            {
                SqlCommand cmd2 = new SqlCommand("Insert into Cart(AlbumId,Count,DateCreated,CartId) values(" + id + "," + count + ",'" + datecreated + "'," + id + ")", conn);
                cmd2.ExecuteNonQuery();
            }
           
        }
    }
}