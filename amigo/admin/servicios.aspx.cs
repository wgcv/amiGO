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
    public partial class servicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblcodigo.Visible = false;
            txtcodigo.Visible = false;
            lblservicio.Visible = false;
            txtservicio.Visible = false;
            lblvalor.Visible = false;
            txtvalor.Visible = false;
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
                string sql = "SELECT * FROM servicios WHERE estado='A'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grvservicios.DataSource = ds;
                grvservicios.DataBind();
            }
        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            lblcodigo.Visible = true;
            txtcodigo.Visible = true;
            lblservicio.Visible = true;
            txtservicio.Visible = true;
            lblvalor.Visible = true;
            txtvalor.Visible = true;
            lblestado.Visible = true;
            txtestado.Visible = true;
            lblmensaje.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
            txtcodigo.Enabled = false;
            txtcodigo.Text = "";
            txtservicio.Text = "";
            txtvalor.Text = "";
            txtestado.Text = "";
            txtservicio.Enabled = true;
            txtvalor.Enabled = true;
            txtestado.Enabled = true;
            btngrabar.Enabled = true;
            btnlimpiar.Enabled = true;
            txtcodigo.Enabled = false;
            lblmensaje.Text = "";
            btngrabar.Enabled = true;
            btnlimpiar.Enabled = true;

            Session["modo"] = "I"; //Es para saber si estoy insertando. El objeto Session me sirve para todos los botones
        }

        protected void btnrefrescar_Click(object sender, EventArgs e)
        {
            Response.Redirect("servicios.aspx");
        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {

            txtcodigo.Text = "";
            txtservicio.Text = "";
            txtvalor.Text = "";
            txtestado.Text = "";
            lblmensaje.Text = "";

            txtcodigo.Enabled = true;
            txtservicio.Enabled = true;
            txtvalor.Enabled = true;
            txtestado.Enabled = true;
            txtcodigo.Enabled = false;

            lblbuscar.Visible = true;
            lblestado.Visible = true;
            lblcodigo.Visible = true;
            lblservicio.Visible = true;
            lblvalor.Visible = true;
            txtcodigo.Visible = true;
            txtservicio.Visible = true;
            txtvalor.Visible = true;
            txtestado.Visible = true;
            txtcodigo.Visible = true;

            btngrabar.Enabled = true;
            btnlimpiar.Enabled = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
            
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "SELECT * FROM servicios WHERE estado='A' AND " + ddlbuscar.SelectedValue + " LIKE '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
            DataSet ds = new DataSet(); //Ni tiene ningun parametro, guarda los datos.
            da.Fill(ds);//Ejecutamos la sentencia SELECT y guardamos en ds
            grvservicios.DataSource = ds; //Cogemos el dato del DataSet
            grvservicios.DataBind();//refrescamos
        }

        protected void grvservicios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            lblcodigo.Visible = true;
            txtcodigo.Visible = true;
            lblservicio.Visible = true;
            txtservicio.Visible = true;
            lblvalor.Visible = true;
            txtvalor.Visible = true;
            lblestado.Visible = true;
            txtestado.Visible = true;
            lblmensaje.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
            txtcodigo.Enabled = false;
         
            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = grvservicios.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtservicio.Text = registro.Cells[2].Text;
            txtvalor.Text = registro.Cells[3].Text;
            txtestado.Text = registro.Cells[4].Text;
            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global
            if (e.CommandName == "modificar")//Pregunta si di a moficcar o a eliminar
            {

                txtservicio.Enabled = true;
                txtvalor.Enabled = true;
                txtestado.Enabled = true;
                btngrabar.Enabled = true;
                btnlimpiar.Enabled = true;
                txtcodigo.Enabled = false;
                lblmensaje.Text = "";
                Session["modo"] = "M";

            }
            else
            {
                txtservicio.Enabled = false;
                txtvalor.Enabled = false;
                txtestado.Enabled = false;
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

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "";

            if (Session["modo"] == "I")
            {
                sql = "INSERT INTO servicios(servicio, valor, estado) VALUES(' " + txtservicio.Text + " ' , " + Convert.ToDecimal(txtvalor.Text) + ", 'A')";
            }
            else
            {
                if (Session["modo"] == "M")
                {
                    sql = "UPDATE  servicios SET servicio = '" + txtservicio.Text + " ', valor= " + Convert.ToDecimal(txtvalor.Text) + " , estado = '" + txtestado.Text + "' WHERE codigo=" + Session["codigo"];

                }



                else
                {//Eliminacion, es una elminacion logica, no fisica. Quiere decir que solo cambio el estado a Innactivo
                    sql = "UPDATE servicios SET estado = 'I' WHERE codigo = " + Session["codigo"];

                }

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

    }
}