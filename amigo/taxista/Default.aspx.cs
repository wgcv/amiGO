using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace amigo.taxista
{
    public partial class Default : System.Web.UI.Page
    {
         MembershipUser u;
         int unidad;
        protected void Page_Load(object sender, EventArgs e)
        {
            u = System.Web.Security.Membership.GetUser();
            string latitud = "0";
            string longitud = "0";
            if (Request.QueryString["latitud"] != null && Request.QueryString["longitud"] != null)
            {
                latitud = Request.QueryString["latitud"];
                longitud = Request.QueryString["longitud"];
            }
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "UPDATE  ubicacionTaxi SET latitud = " + latitud + " , longitud = " + longitud + " WHERE UserId='" + u.ProviderUserKey.ToString() + "'";

            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();

            /*
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadenaConexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            string sql = "SELECT * FROM registroCarrera WHERE activa='A' AND ChoferId='" + u.ProviderUserKey.ToString()+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                String usuario = Convert.ToString(ds.Tables[0].Rows[0]["UserId"]);

                SqlConnection conexion2 = new SqlConnection(cadenaConexion);
                string sql2 = "SELECT * FROM usuario WHERE UserId='" + usuario + "'";
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conexion);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                lblCelular.Text = "0" + Convert.ToString(ds2.Tables[0].Rows[0]["celular"]);
                lblInformacion.Text = Convert.ToString(ds2.Tables[0].Rows[0]["nombre"]) + " " + Convert.ToString(ds2.Tables[0].Rows[0]["apellido"]);


                lblDireccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);
                lblValor.Text = Convert.ToString(ds.Tables[0].Rows[0]["valorAprox"]);
                unidad = Convert.ToInt32(ds.Tables[0].Rows[0]["unidad"]);
                lblDireccion.Visible = true;
                lblInformacion.Visible = true;
                lblValor.Visible = true;
                lblCelular.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                btnDisponible.Visible = false;
                btnPasajero.Visible = true;
            }
            else {

                sql = "UPDATE  chofer SET disponible = 'D' WHERE UserId='" + u.ProviderUserKey.ToString()+"'";

                SqlCommand comando = new SqlCommand(sql, conexion);
                conexion.Open();
                int numero_registro = comando.ExecuteNonQuery();
                conexion.Close();
                btnSalir.Visible = true;
                btnDisponible.Visible = false;
            }
            */

        }
        protected void btnPasajero_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "UPDATE  chofer SET disponible = 'P' WHERE UserId='" + u.ProviderUserKey.ToString() + "'";
            
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            btnDisponible.Visible = true;
            btnPasajero.Visible = false;
        }

        protected void btnDisponible_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "UPDATE  chofer SET disponible = 'D' WHERE UserId='" + u.ProviderUserKey.ToString() + "'";

            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
              sql = "UPDATE  registroCarrera SET activa = 'N' WHERE ChoferId='" + u.ProviderUserKey.ToString() + "'";
             comando = new SqlCommand(sql, conexion);
            conexion.Open();
            numero_registro = comando.ExecuteNonQuery();
            conexion.Close();

            sql = "UPDATE  unidades SET disponible = 'D' WHERE codigo='" + unidad + "'";
            comando = new SqlCommand(sql, conexion);
            conexion.Open();
            numero_registro = comando.ExecuteNonQuery();
            conexion.Close();


            btnSalir.Visible = true;
            btnDisponible.Visible = false;
            Response.Redirect("/taxista");
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "UPDATE  chofer SET disponible = 'F' WHERE UserId='" + u.ProviderUserKey.ToString() + "'";

            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            Response.Redirect("~/");
           
        }

      
    }
}