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
    public partial class chofer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblcodigo.Visible = false;
            txtcodigo.Visible = false;
            lbltipolicencia.Visible = false;
            txttipolicencia.Visible = false;
            lblcedula.Visible = false;
            txtcedula.Visible = false;
            lblnombre.Visible = false;
            txtnombre.Visible = false;
            lblhoraEntrada.Visible = false;
            txthoraEntrada.Visible = false;
            lblhsalida.Visible = false;
            txthsalida.Visible = false;
            lbltelefono.Visible = false;
            txttelefono.Visible = false;
            lblestado.Visible = false;
            txtestado.Visible = false;
            DropDownList1.Visible = false;
            Label1.Visible = false;

           // lblusuario.Visible = false;
            //txtusuarioid.Visible = false;
            lblmensaje.Visible = false;
            btngrabar.Visible = false;
            btnlimpiar.Visible = false;
            if (!Page.IsPostBack)
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadenaConexion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string sql = "SELECT * FROM chofer WHERE estado='A'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grvchofer.DataSource = ds;
                grvchofer.DataBind();
            }
        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            lblcodigo.Visible = true;
            txtcodigo.Visible = true;
            lbltipolicencia.Visible = true;
            txttipolicencia.Visible = true;
            lblcedula.Visible = true;
            txtcedula.Visible = true;
            lblnombre.Visible = true;
            txtnombre.Visible = true;
            lblhoraEntrada.Visible = true;
            txthoraEntrada.Visible = true;
            lblhsalida.Visible = true;
            txthsalida.Visible = true;
            lbltelefono.Visible = true;
            txttelefono.Visible = true;
            lblestado.Visible = true;
            lblmensaje.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
            txtcodigo.Enabled = false;
            txtestado.Visible = true;
            DropDownList1.Visible = true;
            Label1.Visible = true;
            txttipolicencia.Enabled = true;
            txtcedula.Enabled = true;
            txtnombre.Enabled = true;
            txthoraEntrada.Enabled = true;
            txthsalida.Enabled = true;
            txttelefono.Enabled = true;
            txtestado.Enabled = true;
            btngrabar.Enabled = true;
      
            txtestado.Enabled = true;
            // txtusuarioid.Enabled = false;
            btngrabar.Enabled = true;
            btnlimpiar.Enabled = true;
            txtcodigo.Text = "";
            txttipolicencia.Text = "";
            txtcedula.Text = "";
            txtnombre.Text = "";
            txthoraEntrada.Text = "";
            txthsalida.Text = "";
            txttelefono.Text = "";
            txtestado.Text = "";
            txtcodigo.Text = "";
           // txtusuarioid.Text = "";
            Session["modo"] = "I";
        }

        protected void btnrefrescar_Click(object sender, EventArgs e)
        {
            Response.Redirect("chofer.aspx");
        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
           lblcodigo.Visible = true;
            txtcodigo.Visible = true;
            lbltipolicencia.Visible = true;
            txttipolicencia.Visible = true;
            lblcedula.Visible = true;
            txtcedula.Visible = true;
            lblnombre.Visible = true;
            txtnombre.Visible = true;
            lblhoraEntrada.Visible = true;
            txthoraEntrada.Visible = true;
            lblhsalida.Visible = true;
            txthsalida.Visible = true;
            lbltelefono.Visible = true;
            txttelefono.Visible = true;
            lblestado.Visible = true;
            txtestado.Visible = true;
            lblmensaje.Visible = true;
            txtestado.Text = "A";
            txtestado.Visible = true;
            DropDownList1.Visible = true;
            Label1.Visible = true;
           
            txtcodigo.Enabled = false;

            txtcodigo.Text = "";
            txttipolicencia.Text = "";
            txtcedula.Text = "";
            txtnombre.Text = "";
            txthoraEntrada.Text = "";
            txthsalida.Text = "";
            txttelefono.Text = "";
            txtestado.Text = "A";
            txtcodigo.Text = "";
           //txtusuarioid.Text = "";
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            string sql = "SELECT * FROM chofer WHERE estado='A' AND " + ddllist.SelectedValue + " LIKE '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
            DataSet ds = new DataSet(); //Ni tiene ningun parametro, guarda los datos.
            da.Fill(ds);//Ejecutamos la sentencia SELECT y guardamos en ds
            grvchofer.DataSource = ds; //Cogemos el dato del DataSet
            grvchofer.DataBind();//refrescamos
        }

        protected void grvchofer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            lblcodigo.Visible = true;
            txtcodigo.Visible = true;
            lbltipolicencia.Visible = true;
            txttipolicencia.Visible = true;
            lblcedula.Visible = true;
            txtcedula.Visible = true;
            lblnombre.Visible = true;
            txtnombre.Visible = true;
            lblhoraEntrada.Visible = true;
            txthoraEntrada.Visible = true;
            lblhsalida.Visible = true;
            txthsalida.Visible = true;
            lbltelefono.Visible = true;
            txttelefono.Visible = true;
            lblestado.Visible = true;
            txtestado.Visible = true;
            lblmensaje.Visible = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
            txtestado.Visible = true;
            DropDownList1.Visible = true;
            Label1.Visible = false;
            txtcodigo.Enabled = false;

            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = grvchofer.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;
            txttipolicencia.Text = registro.Cells[2].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtcedula.Text = registro.Cells[3].Text;
            txtnombre.Text = registro.Cells[4].Text;
            txthoraEntrada.Text = registro.Cells[5].Text;
            txthsalida.Text = registro.Cells[6].Text;
            txttelefono.Text = registro.Cells[7].Text;
            txtestado.Text = registro.Cells[8].Text;
           // txtusuarioid.Text = registro.Cells[9].Text;
            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global

            if (e.CommandName == "modificar")//Pregunta si di a moficcar o a eliminar
            {


                txttipolicencia.Enabled = true;
                txtcedula.Enabled = true;
                txtnombre.Enabled = true;
                txthoraEntrada.Enabled = true;
                txthsalida.Enabled = true;
                txttelefono.Enabled = true;
                txtestado.Enabled = true;

                btngrabar.Enabled = true;
                txtcodigo.Enabled = false;
                txtestado.Enabled = true;
                txtestado.Visible = true;
                DropDownList1.Visible = true;
                Label1.Visible = true;
                btngrabar.Enabled = true;
                btnlimpiar.Enabled = true;

                txtcodigo.Enabled = false;
                lblmensaje.Text = "";
                Session["modo"] = "M";

            }
            else
            {
                txttipolicencia.Enabled = false;
                txtcedula.Enabled = false;
                txtnombre.Enabled = false;
                txthoraEntrada.Enabled = false;
                txthsalida.Enabled = false;
                txttelefono.Enabled = false;
                txtestado.Enabled = false;
                btngrabar.Enabled = false;
                txtcodigo.Enabled = false;
                txtestado.Enabled = false;
                txtestado.Visible = false;
                DropDownList1.Visible = false;
                Label1.Visible = false;
                btngrabar.Enabled = true;
                btnlimpiar.Enabled = true;
                //btngrabar.Text = "Eliminar";
                Session["modo"] = "E";
                lblmensaje.Text = "Esta seguro que desea eliminar el registro?";
                
            }



        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            {
                lblmensaje.Text = "";
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadena_conexion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                string sql = "";
                if (Session["modo"] == "I")
                {
                    sql = "INSERT INTO chofer(tipolicencia, cedula, nombre, horaEntrada, horaSalida, telefono, UserId) VALUES('" + txttipolicencia.Text + "' , '" + txtcedula.Text + "' , '" + txtnombre.Text + "', '" + txthoraEntrada.Text + "',  '" + txthsalida.Text + "','" + txttelefono.Text + "','"+DropDownList1.SelectedValue +"')";
                }
                else
                {
                    if (Session["modo"] == "M")
                    {
                        sql = "UPDATE  chofer SET tipolicencia = '" + txttipolicencia.Text + "' , cedula = '" + txtcedula.Text + "', nombre = '" + txtnombre.Text + "', horaEntrada='" + txthoraEntrada.Text +"', horaSalida='" + txthsalida.Text+"', telefono = '" + txttelefono.Text + "'WHERE codigo=" + Session["codigo"];

                    }
                    else
                    {//Eliminacion, es una elminacion logica, no fisica. Quiere decir que solo cambio el estado a Innactivo
                        sql = "UPDATE chofer SET estado = 'I' WHERE codigo = " + Session["codigo"];
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
}