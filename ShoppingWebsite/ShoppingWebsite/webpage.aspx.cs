using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ShoppingWebsite
{
    public partial class webpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select Title,A.Name as 'Artist Name',G.Name as 'Genre Name' from Artist as A inner join Album on A.ArtistId =Album.ArtistId inner join Genre as G on G.GenereID = Album.GenreId; ", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Repeater1.DataSource = dr;
            Repeater1.DataBind();
            conn.Close();
            
        }

      
           
      

        

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
        }
    }
}