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
    public partial class comentarios1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblcodigo.Visible = false;
            lblmsj.Visible = false;
            lblnombre.Visible = false;
            txtcodigo.Visible = false;
            txtmensaje.Visible = false;
            txtnombre.Visible = false;
           
            lblmensaje.Visible = false;
            btneliminar.Visible = false;
            if (!Page.IsPostBack)
            {
                clase_general general = new clase_general();
                DataSet ds = general.consulta_comentarios();
                grvcomentarios.DataSource = ds;
                grvcomentarios.DataBind();
            }
        }

        protected void grvcomentarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           

            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = grvcomentarios.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;
            txtnombre.Text = registro.Cells[2].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtmensaje.Text = registro.Cells[3].Text;
            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global
            lblcodigo.Visible = true;
            lblmsj.Visible = true;
            lblmensaje.Visible = true;
            lblnombre.Visible = true;
            txtcodigo.Visible = true;
            txtmensaje.Visible = true;
            txtnombre.Visible = true;
            btneliminar.Visible = true;
            txtcodigo.Enabled = false;
            txtmensaje.Enabled = false;
            txtnombre.Enabled = false;
            lblmensaje.Text = "Esta seguro que desea eliminar el registro?";

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            clase_general general = new clase_general();
            int numero_registro = general.elimina_comentarios(Convert.ToInt32(Session["codigo"]));
            Response.Redirect("comentarios.aspx");
                
        }

        protected void btnrefrescar_Click(object sender, EventArgs e)
        {
            Response.Redirect("comentarios.aspx");
        }



      
    }
}