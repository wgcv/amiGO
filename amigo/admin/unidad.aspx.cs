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
            txtdisponible.Visible = false;
            lbldisponible.Visible = false;
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
                clase_general general = new clase_general();
                DataSet ds = general.consulta_unidades("G", "", "");
                grvunidad.DataSource = ds;
                grvunidad.DataBind();
               
                DataSet d1 = general.consulta_zona();
                ddlZona.DataSource = d1.Tables[0].DefaultView;
                ddlZona.DataValueField = "codigo";
                ddlZona.DataTextField = "nombre_zona";
                ddlZona.DataBind();

                DataSet d2 = general.consulta_chofer("G", "", "");
                ddlChofe.DataSource = d2.Tables[0].DefaultView;
                ddlChofe.DataValueField = "codigo";
                ddlChofe.DataTextField = "nombre";
                ddlChofe.DataBind();

                DataSet d3 = general.consulta_tipoUnidad();
                ddlTipoUnidad.DataSource = d3.Tables[0].DefaultView;
                ddlTipoUnidad.DataValueField = "codigo";
                ddlTipoUnidad.DataTextField = "tipo";
                ddlTipoUnidad.DataBind();

            }
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {

            clase_general general = new clase_general();
            DataSet ds = general.consulta_unidades("E", ddllist.SelectedValue, txtbuscar.Text);
            grvunidad.DataSource = ds;
            grvunidad.DataBind();
            
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
            txtdisponible.Text = "";

            lblmensaje.Text = "";
            txtdisponible.Visible = true;
            lbldisponible.Visible = true;

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
            Session["codi"] = 100000;
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

            lbldisponible.Text = "";
            txtdisponible.Text = "";

            lblmensaje.Text = "";
            txtdisponible.Visible = true;
            lbldisponible.Visible = true;

    
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
            int numero_registro = 0;
            if (Session["modo"] == "E")
            {
                clase_general general = new clase_general();
                general = new clase_general();
                numero_registro = general.elimina_unidades(Convert.ToInt32(Session["codigo"]));

            }
            else
            {
                clase_general general = new clase_general();
                numero_registro = general.ins_updateunidades(Convert.ToInt32(Session["codi"]), txtmodelo.Text, txtmarca.Text, Convert.ToInt16(txtaño.Text), txtplaca.Text, Convert.ToDecimal(txtvalorKm.Text), Convert.ToInt16(ddlZona.SelectedValue), Convert.ToInt16(ddlChofe.SelectedValue), Convert.ToInt16(ddlTipoUnidad.SelectedValue), txtestado.Text, txtdisponible.Text);
            }
          
            Response.Redirect("unidad.aspx");

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
            txtdisponible.Visible = true;
            lbldisponible.Visible = true;
            lbldisponible.Visible = true;
            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = grvunidad.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtmodelo.Text = registro.Cells[2].Text;
            txtmarca.Text = registro.Cells[3].Text;
            txtaño.Text = registro.Cells[4].Text;
            txtplaca.Text = registro.Cells[5].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtvalorKm.Text = registro.Cells[6].Text;
           /* ddlZona.SelectedItem.Text = registro.Cells[7].Text;
            ddlChofe.SelectedItem.Text = registro.Cells[8].Text;
            ddlTipoUnidad.SelectedItem.Text = registro.Cells[9].Text;*/
            txtestado.Text = registro.Cells[10].Text;

            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global
            if (e.CommandName == "modificar")//Pregunta si di a moficcar o a eliminar
            {


                txtdisponible.Enabled = true;
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
                Session["codi"] = txtcodigo.Text;
                Session["modo"] = "M";

            }
            else
            {
                lbldisponible.Visible = true;
                txtmodelo.Enabled = false;
                txtdisponible.Enabled = false;
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

        protected void grvunidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
     
        protected void ddlChofe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTipoUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grvunidad_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
      
    }
}