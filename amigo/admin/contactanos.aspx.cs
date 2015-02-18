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
                clase_general general = new clase_general();
                DataSet ds = general.consulta_contactanos("G", "", "");
                grvcontactanos.DataSource = ds;
                grvcontactanos.DataBind();
            }
        }

        protected void btnrefrescar_Click(object sender, EventArgs e)
        {
            Response.Redirect("contactanos.aspx");
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            clase_general general = new clase_general();
            int numero_registro = general.elimina_contactanos(Convert.ToInt32(Session["codigo"]));
            Response.Redirect("contactanos.aspx");
        }

        

        protected void btnbuscar_Click(object sender, EventArgs e)
        {

            clase_general general = new clase_general();
            DataSet ds = general.consulta_contactanos("E", ddlbuscar.SelectedValue, txtbuscar.Text);
            grvcontactanos.DataSource = ds;
            grvcontactanos.DataBind();
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
