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
            txtestado.Visible = false;
            lblestado.Visible = false;

            if (!Page.IsPostBack)
            {
                clase_general general = new clase_general();
                DataSet ds = general.consulta_tipounidad("G", "", "");
                grvtipo.DataSource = ds;
                grvtipo.DataBind();
            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            clase_general general = new clase_general();
            DataSet ds = general.consulta_tipounidad("E", ddlbuscar.SelectedValue, txtbuscar.Text);
            grvtipo.DataSource = ds;
            grvtipo.DataBind();
            
        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            int numero_registro = 0;
            if (Session["modo"] == "E")
            {
                clase_general general = new clase_general();
                numero_registro = general.elimina_tipounidad(Convert.ToInt32(Session["codigo"]));

            }
            else
            {
                clase_general general = new clase_general();
                numero_registro = general.ins_updatetipounidad(Convert.ToInt32(Session["codi"]), txttipounidad.Text, txtestado.Text);
                
            }
            Response.Redirect("tipoUnidades.aspx");

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
            txtestado.Visible = true;
            lblestado.Visible = true;
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
            txtestado.Visible = true;
            lblestado.Visible = true;
            txttipounidad.Enabled = true;
            txtcodigo.Enabled = false;

            txtcodigo.Text = "";
            txttipounidad.Text = "";
            Session["codi"] = 100000;
            
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
            txtestado.Visible = true;
            lblestado.Visible = true;
            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = grvtipo.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txttipounidad.Text = registro.Cells[2].Text;
            txtestado.Text = registro.Cells[3].Text;
           
            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global
            if (e.CommandName == "modificar")//Pregunta si di a moficcar o a eliminar
            {

                txttipounidad.Enabled = true;
               
                btngrabar.Enabled = true;
                btnlimpiar.Enabled = true;
                txtcodigo.Enabled = false;
                lblmensaje.Text = "";
                Session["codi"] = txtcodigo.Text;

            }
            else
            {
                txttipounidad.Enabled = false;
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

       
    }
}