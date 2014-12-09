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
            ddlChofe.Visible = false;
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
            ddlZona.Visible = false;
            lbltipounidad.Visible = false;
            ddlTipoUnidad.Visible = false;
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

      
        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtmodelo.Text = "";
            txtmarca.Text = "";
            txtaño.Text = "";
            txtplaca.Text = "";
            txtvalorKm.Text = "";
           
            txtestado.Text = "";

            lblmensaje.Text = "";

            txtmodelo.Visible = true;
            txtmarca.Visible = true;
            txtestado.Visible = true;
            txtcodigo.Visible = true;
            ddlChofe.Visible = true;
            ddlTipoUnidad.Visible = true;
            txtaño.Visible = true;
            txtplaca.Visible = true;
            txtvalorKm.Visible = true;
            ddlZona.Visible = true;

            lblmodelo.Visible = true;
            lblmarca.Visible = true;
            lblestado.Visible = true;
            lblcodigo.Visible = true;
            lblchofer.Visible = true;
            lbltipounidad.Visible = true;
            lblaño.Visible = true;
            lblplaca.Visible = true;
            lblvalorKm.Visible = true;
            lblzona.Visible = true;

            btngrabar.Enabled = true;
            btnlimpiar.Enabled = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;

            txtmodelo.Enabled = true;
            txtmarca.Enabled = true;
            txtestado.Enabled = true;
            txtcodigo.Enabled = false;
            ddlChofe.Enabled = true;
            ddlTipoUnidad.Enabled = true;
            txtaño.Enabled = true;
            txtplaca.Enabled = true;
            txtvalorKm.Enabled = true;
            ddlZona.Enabled = true;
            Session["modo"] = "I"; //Es para saber si estoy insertando. El objeto Session me sirve para todos los botones
        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtmodelo.Text = "";
            txtmarca.Text = "";
            txtaño.Text = "";
            txtplaca.Text = "";
            txtvalorKm.Text = "";
            ddlChofe.Text = "";
            txtestado.Text = "";

            lblmensaje.Text = "";

    
            txtmodelo.Enabled = true;
            txtmarca.Enabled = true;
            txtestado.Enabled = true;
            txtcodigo.Enabled = false;
            ddlChofe.Enabled = true;
            ddlTipoUnidad.Enabled = true;
            txtaño.Enabled = true;
            txtplaca.Enabled = true;
            txtvalorKm.Enabled = true;
            ddlZona.Enabled = true;

            txtmodelo.Visible = true;
            txtmarca.Visible = true;
            txtestado.Visible = true;
            txtcodigo.Visible = false;
            ddlChofe.Visible = true;
            ddlTipoUnidad.Visible = true;
            txtaño.Visible = true;
            txtplaca.Visible = true;
            txtvalorKm.Visible = true;
            ddlZona.Visible = true;

            lblmodelo.Visible = true;
            lblmarca.Visible = true;
            lblestado.Visible = true;
            lblcodigo.Visible = true;
            lblchofer.Visible = true;
            lbltipounidad.Visible = true;
            lblaño.Visible = true;
            lblplaca.Visible = true;
            lblvalorKm.Visible = true;
            lblzona.Visible = true;

            btngrabar.Enabled = true;
            btnlimpiar.Enabled = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;
        }

        protected void btnrefrescar_Click(object sender, EventArgs e)
        {
            Response.Redirect("unidad.aspx");
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
                    sql = "INSERT INTO unidades(modelo,marca,ano,placa,valorKm,zona,chofer,tipoUnidad,estado) VALUES(' " + txtmodelo.Text + " ' , ' " + txtmarca.Text + " ' , " + Convert.ToInt16(txtaño.Text) + ", ' " + txtplaca.Text + " ' , " + Convert.ToDecimal(txtvalorKm.Text) + " , " + ddlZona.SelectedValue + " , " + ddlChofe.SelectedValue + " , " + ddlTipoUnidad.SelectedValue + " , 'A')";
                }
                else
                {
                    if (Session["modo"] == "M")
                    {
                        sql = "UPDATE  unidades SET modelo = '" + txtmodelo.Text + " ', marca = '" + txtmarca.Text + " ', ano= " + Convert.ToInt16(txtaño.Text) + " ,placa = '" + txtplaca.Text + " ', valorKm= " + Convert.ToDecimal(txtvalorKm.Text) + " , zona= " + ddlZona.SelectedValue + " , chofer= " + ddlChofe.SelectedValue + " , tipoUnidad= " + ddlTipoUnidad.SelectedValue + " , estado = '" + txtestado.Text + "' WHERE codigo=" + Session["codigo"];

                    }



                    else
                    {//Eliminacion, es una elminacion logica, no fisica. Quiere decir que solo cambio el estado a Innactivo
                        sql = "UPDATE unidades SET estado = 'I' WHERE codigo = " + Session["codigo"];

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

        protected void grvunidad_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            txtmodelo.Visible = true;
            txtmarca.Visible = true;
            txtestado.Visible = true;
            txtcodigo.Visible = true;
            ddlChofe.Visible = true;
            ddlTipoUnidad.Visible = true;
            txtaño.Visible = true;
            txtplaca.Visible = true;
            txtvalorKm.Visible = true;
            ddlZona.Visible = true;
            lblmensaje.Visible = true;
            lblmodelo.Visible = true;
            lblmarca.Visible = true;
            lblestado.Visible = true;
            lblcodigo.Visible = true;
            lblchofer.Visible = true;
            lbltipounidad.Visible = true;
            lblaño.Visible = true;
            lblplaca.Visible = true;
            lblvalorKm.Visible = true;
            lblzona.Visible = true;
            txtcodigo.Enabled = false;
            btngrabar.Enabled = true;
            btnlimpiar.Enabled = true;
            btngrabar.Visible = true;
            btnlimpiar.Visible = true;

            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = grvunidad.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtmodelo.Text = registro.Cells[2].Text;
            txtmarca.Text = registro.Cells[3].Text;
            txtaño.Text = registro.Cells[4].Text;
            txtplaca.Text = registro.Cells[5].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtvalorKm.Text = registro.Cells[6].Text;
            ddlZona.SelectedValue = registro.Cells[7].Text;
            ddlChofe.SelectedValue = registro.Cells[8].Text;
            ddlTipoUnidad.SelectedValue = registro.Cells[9].Text;
            txtestado.Text = registro.Cells[10].Text;


            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global
            if (e.CommandName == "modificar")//Pregunta si di a moficcar o a eliminar
            {

                txtmodelo.Enabled = true;
                txtmarca.Enabled = true;
                txtestado.Enabled = true;
                txtcodigo.Enabled = false;
                ddlChofe.Enabled = true;
                ddlTipoUnidad.Enabled = true;
                txtaño.Enabled = true;
                txtplaca.Enabled = true;
                txtvalorKm.Enabled = true;
                ddlZona.Enabled = true;
                txtestado.Enabled = true;
                btngrabar.Enabled = true;
                btnlimpiar.Enabled = true;


                txtcodigo.Enabled = false;

                lblmensaje.Text = "";
                Session["modo"] = "M";

            }
            else
            {
                txtmodelo.Enabled = false;
                txtmarca.Enabled = false;
                txtestado.Enabled = false;
                txtcodigo.Enabled = false;
                ddlChofe.Enabled = false;
                ddlTipoUnidad.Enabled = false;
                txtaño.Enabled = false;
                txtplaca.Enabled = false;
                txtvalorKm.Enabled = false;
                ddlZona.Enabled = false;
                txtestado.Enabled = false;
              
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