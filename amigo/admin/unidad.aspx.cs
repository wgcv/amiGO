using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace amigo.admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblchofer.Visible = false;
            txtchofer.Visible = false;
            lblcodigo.Visible = false;
            txtcodigo.Visible = false;
            lblmodelo.Visible = false;
            txtmodelo.Visible = false;
            lblmarca.Visible = false;
            txtmarca.Visible = false;
            lblaño.Visible = false;
            txtaño.Visible = false;
            lblplaca.Visible = false;
            txtplaca.Visible = false;
            lblvalorKm.Visible = false;
            txtvalorKm.Visible = false;
            lblzona.Visible = false;
            txtzona.Visible = false;
            lbltipounidad.Visible = false;
            txttipounidad.Visible = false;
            lblestado.Visible = false;
            txtestado.Visible = false;
            lblmensaje.Visible = false;
            btngrabar.Visible = false;
            btnlimpiar.Visible = false;


             if (!Page.IsPostBack)
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadenaConexion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string sql = "SELECT * FROM unidades WHERE estado='A'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grvunidad.DataSource = ds;
                grvunidad.DataBind();
               
            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadena_conexion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                string sql = "SELECT * FROM unidades WHERE estado='A' AND " + ddllist.SelectedValue + " LIKE '%" + txtbuscar.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataSet ds = new DataSet(); //Ni tiene ningun parametro, guarda los datos.
                da.Fill(ds);//Ejecutamos la sentencia SELECT y guardamos en ds
                grvunidad.DataSource = ds; //Cogemos el dato del DataSet
                grvunidad.DataBind();//refrescamos
            }
        }

        protected void btnbuscar_Click1(object sender, EventArgs e)
        {

        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {

        }

      
    }
}