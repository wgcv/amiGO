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
    public partial class TipoUnidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblcodigo.Visible = false;
            lblmensaje.Visible = false;
            lbltipounidad.Visible = false;
            txtcodigo.Visible = false;
            txttipounidad.Visible = false;
            btngrabar.Visible = false;
            btnlimpiar.Visible = false;


            if (!Page.IsPostBack)
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadenaConexion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string sql = "SELECT * FROM tipoUnidades";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grvtipo.DataSource = ds;
                grvtipo.DataBind();
            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "SELECT * FROM tipoUnidades WHERE  " + ddlbuscar.SelectedValue + " LIKE '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
            DataSet ds = new DataSet(); //Ni tiene ningun parametro, guarda los datos.
            da.Fill(ds);//Ejecutamos la sentencia SELECT y guardamos en ds
            grvtipo.DataSource = ds; //Cogemos el dato del DataSet
            grvtipo.DataBind();//refrescamos
            
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {

            lblmensaje.Text = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "";

            if (Session["modo"] == "I")
            {
                sql = "INSERT INTO tipoUnidades (tipo) VALUES('" + txttipounidad.Text + "' )";
            }
            else
            {
                if (Session["modo"] == "M")
                {
                    sql = "UPDATE  tipoUnidades SET tipo = '" + txttipounidad.Text + "' WHERE codigo=" + Session["codigo"];

                }



                /*else
                {//Eliminacion, es una elminacion logica, no fisica. Quiere decir que solo cambio el estado a Innactivo
                  //  sql = "UPDATE unidades SET estado = 'I' WHERE codigo = " + Session["codigo"];

                }*/

            }



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

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
            lblcodigo.Visible = true;
            lblmensaje.Visible = true;
            lbltipounidad.Visible = true;
            txtcodigo.Visible = true;
            txttipounidad.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;

            txttipounidad.Enabled = true;
            txtcodigo.Enabled = false;

            txtcodigo.Text = "";
            txttipounidad.Text = "";
        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            lblcodigo.Visible = true;
            lblmensaje.Visible = true;
            lbltipounidad.Visible = true;
            txtcodigo.Visible = true;
            txttipounidad.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;

            txttipounidad.Enabled = true;
            txtcodigo.Enabled = false;

            txtcodigo.Text = "";
            txttipounidad.Text = "";

            Session["modo"] = "I";
        }

        protected void btnrefrescar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TipoUnidades.aspx");
        }

        protected void grvtipo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            lblcodigo.Visible = true;
            lblmensaje.Visible = true;
            lbltipounidad.Visible = true;
            txtcodigo.Visible = true;
            txttipounidad.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
            txtcodigo.Enabled = false;

            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = grvtipo.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txttipounidad.Text = registro.Cells[2].Text;
           
            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global
            if (e.CommandName == "modificar")//Pregunta si di a moficcar o a eliminar
            {

                txttipounidad.Enabled = true;
               
                btngrabar.Enabled = true;
                btnlimpiar.Enabled = true;
                txtcodigo.Enabled = false;
                lblmensaje.Text = "";
                Session["modo"] = "M";

            }
            else
            {
                txttipounidad.Enabled = false;
         
                btngrabar.Enabled = false;
                btnlimpiar.Enabled = false;
                lblmensaje.Text = "";
                btngrabar.Enabled = true;
                btnlimpiar.Enabled = false;
                txtcodigo.Enabled = false;
                Session["modo"] = "E";
                lblmensaje.Text = "Esta seguro que desea eliminar el registro?";
            }
        }

       
    }
}