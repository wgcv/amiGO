using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace amigo
{
    public partial class contactanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnenviarmensaje_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadenaConexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            string sql = "INSERT INTO contactanos (nombre,correo,asunto,mensaje,leido) VALUES('" + txtNombre.Text + "','" + txtEmail.Text + "','" + txtAsunto.Text + "','" +txtMensaje.Text+ "','N')";
            SqlCommand commando = new SqlCommand(sql, conexion);
            conexion.Open();
            int numeo_registro = commando.ExecuteNonQuery();
            Response.Redirect("enviado.aspx");
        }

    }
}