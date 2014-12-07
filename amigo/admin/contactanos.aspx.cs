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
    public partial class comentarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblcodigo.Visible = false;
            lblmsj.Visible = false;
            lblnombre.Visible = false;
            lblcorreo.Visible = false;
            lblasunto.Visible = false;
            lblleido.Visible = false;
            txtleido.Visible = false;
            txtasunto.Visible = false;
            txtcorreo.Visible = false;
            txtcodigo.Visible = false;
            txtmensaje.Visible = false;
            txtnombre.Visible = false;
            lblmensaje.Visible = false;
            btneliminar.Visible = false;
            if (!Page.IsPostBack)
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadenaConexion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string sql = "SELECT codigo,nombre,correo,asunto,mensaje,leido FROM contactanos WHERE leido='N'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grvcontactanos.DataSource = ds;
                grvcontactanos.DataBind();
            }
        }

        protected void btnrefrescar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/contactanos.aspx");
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
              lblmensaje.Text = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "UPDATE contactanos SET leido = 'Y' WHERE codigo = " + Session["codigo"];
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();
            int numero_registro = comando.ExecuteNonQuery();
            if (numero_registro == 1)
            {
                lblmensaje.Text = "La Transaccion fue realizada con exito ";
            }
            else
            {

                lblmensaje.Text = "Ocurrio un error al ejecutar la transaccion ";
            }
            conexion.Close();
        }

        

        protected void btnbuscar_Click(object sender, EventArgs e)
        {

            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "SELECT codigo,nombre,correo,asunto,mensaje,leido FROM contactanos WHERE  " + ddlbuscar.SelectedValue + " LIKE '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
            DataSet ds = new DataSet(); //Ni tiene ningun parametro, guarda los datos.
            da.Fill(ds);//Ejecutamos la sentencia SELECT y guardamos en ds
            grvcontactanos.DataSource = ds; //Cogemos el dato del DataSet
            grvcontactanos.DataBind();//refrescamos
        }

        protected void grvcontactanos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = grvcontactanos.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;
            txtnombre.Text = registro.Cells[2].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtcorreo.Text = registro.Cells[3].Text;
            txtasunto.Text = registro.Cells[4].Text;
            txtmensaje.Text = registro.Cells[5].Text;
            txtleido.Text = registro.Cells[6].Text;
            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global
            lblcodigo.Visible = true;
            lblmensaje.Visible = true;
            lblnombre.Visible = true;
            lblasunto.Visible = true;
            lblmsj.Visible = true;
            lblcorreo.Visible = true;
            lblleido.Visible = true;
            txtcodigo.Visible = true;
            txtmensaje.Visible = true;
            txtnombre.Visible = true;
            txtasunto.Visible = true;
            txtmensaje.Visible = true;
            txtcorreo.Visible = true;
            txtleido.Visible = true;

            txtcodigo.Enabled = false;
            txtmensaje.Enabled = false;
            txtnombre.Enabled = false;
            txtasunto.Enabled = false;
            txtmensaje.Enabled = false;
            txtcorreo.Enabled = false;
            txtleido.Enabled = false;
            btneliminar.Visible = true;
            lblmensaje.Text = "Esta seguro que desea eliminar el registro?";
        }
        }

      
    }
