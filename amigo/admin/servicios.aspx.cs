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
                clase_general general = new clase_general();
                DataSet ds = general.consulta_servicios("G", "", "");
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
            Session["codi"] = 100000;
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
            clase_general general = new clase_general();
            DataSet ds = general.consulta_servicios("E", ddlbuscar.SelectedValue, txtbuscar.Text);
            grvservicios.DataSource = ds;
            grvservicios.DataBind();
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
                Session["codi"] = txtcodigo.Text;

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
            int numero_registro = 0;
            if (Session["modo"] == "E")
            {
                clase_general general = new clase_general();
                numero_registro = general.elimina_servicios(Convert.ToInt32(Session["codigo"]));
                
            }
            else {
                clase_general general = new clase_general();
                numero_registro = general.ins_updateservicios(Convert.ToInt32(Session["codi"]),txtservicio.Text, Convert.ToDecimal(txtvalor.Text), txtestado.Text);
                Response.Redirect("servicios.aspx");
            }
            Response.Redirect("servicios.aspx");
                }

}
}