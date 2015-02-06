using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace amigo
{
    public partial class consultataxi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadenaConexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadenaConexion);

                SqlConnection conexion2 = new SqlConnection(cadenaConexion);
                string sql2 = "SELECT * FROM ubicacionTaxi WHERE UserId='" + Request.QueryString["id"] + "'";
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conexion);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
            Response.Write("{\"latitud\": "+  Convert.ToString(ds2.Tables[0].Rows[0]["latitud"]) +",\"longitud\": "+Convert.ToString(ds2.Tables[0].Rows[0]["longitud"])+"}");
             
                  
        }
    }
}