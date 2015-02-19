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
    public partial class registroCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtdireccionllegada.Visible = false;
            ddlzonallegada.Visible = false;
            ddlciudadelallegada.Visible = false;
            lblciudadelallegada.Visible = false;
            lblzona1.Visible = false;
            lblciudadela.Visible = false;
            ddlciudadela.Visible = false;
            lbldestino.Visible = false;
            ddlnombre.Visible = false;
            lblnombre.Visible = false;
            lblcodigo.Visible = false;
            lblchfofer.Visible = false;
            lbldireccion.Visible = false;
            lbldistancia.Visible = false;
            lblfecha.Visible = false;
            lblservicio.Visible = false;
            lbltipoUnidad.Visible = false;
            lblunidad.Visible = false;
            lblvalor.Visible = false;
            lblzona.Visible = false;
            lblestadocarrera.Visible = false;
            txtcodigo.Visible = false;
            txtdireccion.Visible = false;
            txtdistancia.Visible = false;
            txtestadocarrera.Visible = false;
            txtfecha.Visible = false;
            txtvalor.Visible = false;
            ddlchofer.Visible = false;
            ddlservicio.Visible = false;
            ddltipoUnidad.Visible = false;
            ddlunidad.Visible = false;
            ddlzona.Visible = false;
            Bgrabar.Visible = false;
            Blimpiar.Visible = false;
            lbldireccionllegada.Visible = false;

            if (!Page.IsPostBack)
            {
                clase_general general = new clase_general();
                DataSet ds = general.consulta_carreras();
                gvrcarreras.DataSource = ds;
                gvrcarreras.DataBind();


                DataSet d1 = general.consulta_zona();
                ddlzona.DataSource = d1.Tables[0].DefaultView;
                ddlzona.DataValueField = "codigo";
                ddlzona.DataTextField = "nombre_zona";
                ddlzona.DataBind();

                ddlzonallegada.DataSource = d1.Tables[0].DefaultView;
                ddlzonallegada.DataValueField = "codigo";
                ddlzonallegada.DataTextField = "nombre_zona";
                ddlzonallegada.DataBind();

                DataSet d2 = general.consulta_chofer("G", "", "");
                ddlchofer.DataSource = d2.Tables[0].DefaultView;
                ddlchofer.DataValueField = "UserId";
                ddlchofer.DataTextField = "nombre";
                ddlchofer.DataBind();

                DataSet d3 = general.consulta_tipoUnidad();
                ddltipoUnidad.DataSource = d3.Tables[0].DefaultView;
                ddltipoUnidad.DataValueField = "codigo";
                ddltipoUnidad.DataTextField = "tipo";
                ddltipoUnidad.DataBind();

                DataSet d4 = general.consulta_servicios("G", "", "");
                ddlservicio.DataSource = d4.Tables[0].DefaultView;
                ddlservicio.DataValueField = "codigo";
                ddlservicio.DataTextField = "nombre_servicio";
                ddlservicio.DataBind();
                

                DataSet d5 = general.consulta_unidades("G", "", "");
                ddlunidad.DataSource = d5.Tables[0].DefaultView;
                ddlunidad.DataValueField = "codigo";
                ddlunidad.DataTextField = "modelo";
                ddlunidad.DataBind();

                DataSet d6 = general.consulta_usuario();
                ddlnombre.DataSource = d6.Tables[0].DefaultView;
                ddlnombre.DataValueField = "UserId";
                ddlnombre.DataTextField = "UserName";
                ddlnombre.DataBind();
               
                DataSet d7 = general.consulta_ciudadela( Convert.ToInt32(ddlzona.SelectedValue));
                ddlciudadela.DataSource = d7.Tables[0].DefaultView;
                ddlciudadela.DataValueField = "codigo";
                ddlciudadela.DataTextField = "ciudadela";
                ddlciudadela.DataBind();

                DataSet d8 = general.consulta_ciudadela(Convert.ToInt32(ddlzonallegada.SelectedValue));
                ddlciudadelallegada.DataSource = d8.Tables[0].DefaultView;
                ddlciudadelallegada.DataValueField = "codigo";
                ddlciudadelallegada.DataTextField = "ciudadela";
                ddlciudadelallegada.DataBind();

            }

        }





        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }



        protected void Bnuevo_Click(object sender, EventArgs e)
        {
            txtdireccionllegada.Visible = true;
            ddlzonallegada.Visible = true;
            ddlciudadelallegada.Visible = true;
            lblciudadelallegada.Visible = true;
            lblzona1.Visible = true;
            lblcodigo.Visible = true;
            lblchfofer.Visible = true;
            lbldireccion.Visible = true;
            lbldistancia.Visible = true;
            lblfecha.Visible = true;
            lblservicio.Visible = true;
            lbltipoUnidad.Visible = true;
            lblunidad.Visible = true;
            lblvalor.Visible = true;
            lblzona.Visible = true;
            lblestadocarrera.Visible = true;
            txtcodigo.Visible = true;
            txtdireccion.Visible = true;
            txtdistancia.Visible = true;
            txtestadocarrera.Visible = true;
            txtfecha.Visible = true;
            txtvalor.Visible = true;
            ddlchofer.Visible = false;
            ddlservicio.Visible = false;
            ddltipoUnidad.Visible = false;
            ddlunidad.Visible = false;
            ddlzona.Visible = false;
            Bgrabar.Visible = false;
            ddlzona.Visible = true;
            ddlchofer.Visible = true;
            ddlservicio.Visible = true;
            ddlunidad.Visible = true;
            ddltipoUnidad.Visible = true;
            txtcodigo.Enabled = false;
            Bgrabar.Visible = true;
            Blimpiar.Visible = true;
            ddlnombre.Visible = true;
            lblnombre.Visible = true;
            lbldestino.Visible = true;
            lblciudadela.Visible = true;
            ddlciudadela.Visible = true;
            lbldireccionllegada.Visible = true;


            Session["codi"] = 100000;



        }

        protected void Blimpiar_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtdireccion.Text = "";
            txtdistancia.Text = "";
            txtestadocarrera.Text = "";
            txtfecha.Text = "";
            ddlnombre.Text = "";
            txtvalor.Text = "";
            lblcodigo.Visible = true;
            lblchfofer.Visible = true;
            lbldireccion.Visible = true;
            lbldistancia.Visible = true;
            lblfecha.Visible = true;
            lblservicio.Visible = true;
            lbltipoUnidad.Visible = true;
            lblunidad.Visible = true;
            lblvalor.Visible = true;
            lblzona.Visible = true;
            lblestadocarrera.Visible = true;
            txtcodigo.Visible = true;
            txtdireccion.Visible = true;
            txtdistancia.Visible = true;
            txtestadocarrera.Visible = true;
            txtfecha.Visible = true;
            txtvalor.Visible = true;
            ddlchofer.Visible = false;
            ddlservicio.Visible = false;
            ddltipoUnidad.Visible = false;
            ddlunidad.Visible = false;
            ddlzona.Visible = false;
            Bgrabar.Visible = false;
            ddlzona.Visible = true;
            ddlchofer.Visible = true;
            ddlservicio.Visible = true;
            ddlunidad.Visible = true;
            ddltipoUnidad.Visible = true;
            txtcodigo.Enabled = false;
            Bgrabar.Visible = true;
            Blimpiar.Visible = true;
            txtdireccionllegada.Visible = true;
            ddlzonallegada.Visible = true;
            ddlciudadelallegada.Visible = true;
            lblciudadelallegada.Visible = true;
            lblzona1.Visible = true;
        }

        protected void gvrcarreras_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            lblcodigo.Visible = true;
            lblchfofer.Visible = true;
            lbldireccion.Visible = true;
            lbldistancia.Visible = true;
            lblfecha.Visible = true;
            lblservicio.Visible = true;
            lbltipoUnidad.Visible = true;
            lblunidad.Visible = true;
            lblvalor.Visible = true;
            lblzona.Visible = true;
            lblestadocarrera.Visible = true;
            txtcodigo.Visible = true;
            txtdireccion.Visible = true;
            txtdistancia.Visible = true;
            txtestadocarrera.Visible = true;
            txtfecha.Visible = true;
            txtvalor.Visible = true;
            ddlchofer.Visible = false;
            ddlservicio.Visible = false;
            ddltipoUnidad.Visible = false;
            ddlunidad.Visible = false;
            ddlzona.Visible = false;
            Bgrabar.Visible = false;
            ddlzona.Visible = true;
            ddlchofer.Visible = true;
            ddlservicio.Visible = true;
            ddlunidad.Visible = true;
            ddltipoUnidad.Visible = true;
            txtcodigo.Enabled = false;
            Bgrabar.Visible = true;
            Blimpiar.Visible = true;
            txtdireccionllegada.Visible = true;
            ddlzonallegada.Visible = true;
            ddlciudadelallegada.Visible = true;
            lblciudadelallegada.Visible = true;
            lblzona1.Visible = true;

            int fila = Convert.ToInt32(e.CommandArgument); //Recibe la fila que selecciono en SDtring y la convertimos en Entero
            GridViewRow registro = gvrcarreras.Rows[fila];//Guarda los datos de la fila en un registro

            txtcodigo.Text = registro.Cells[1].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            ddlnombre.SelectedItem.Text = registro.Cells[2].Text;
            txtdistancia.Text = registro.Cells[3].Text;
            txtdireccion.Text = registro.Cells[4].Text;
            ddlzona.SelectedItem.Text = registro.Cells[5].Text;//Cells nos ayuda a  recuperar el texto de cada celda
            txtvalor.Text = registro.Cells[6].Text;
            txtfecha.Text = registro.Cells[7].Text;
            ddlunidad.SelectedItem.Text = registro.Cells[8].Text;
            ddlservicio.SelectedItem.Text = registro.Cells[9].Text;
            ddltipoUnidad.SelectedItem.Text = registro.Cells[10].Text;
            txtestadocarrera.Text = registro.Cells[11].Text;
            ddlchofer.SelectedItem.Text = registro.Cells[12].Text;





            Session["codigo"] = registro.Cells[1].Text;//Es como una variable global
            if (e.CommandName == "modificar")//Pregunta si di a moficcar o a eliminar
            {  
                txtdireccionllegada.Visible = true;
                ddlzonallegada.Visible = true;
                ddlciudadelallegada.Visible = true;
                lblciudadelallegada.Visible = true;
                lblzona1.Visible = true;
                lblcodigo.Visible = true;
                lblchfofer.Visible = true;
                lbldireccion.Visible = true;
                lbldistancia.Visible = true;
                lblfecha.Visible = true;
                lblservicio.Visible = true;
                lbltipoUnidad.Visible = true;
                lblunidad.Visible = true;
                lblvalor.Visible = true;
                lblzona.Visible = true;
                lblestadocarrera.Visible = true;
                txtcodigo.Visible = true;
                txtdireccion.Visible = true;
                txtdistancia.Visible = true;
                txtestadocarrera.Visible = true;
                txtfecha.Visible = true;
                txtvalor.Visible = true;
                ddlchofer.Visible = false;
                ddlservicio.Visible = false;
                ddltipoUnidad.Visible = false;
                ddlunidad.Visible = false;
                ddlzona.Visible = false;
                Bgrabar.Visible = false;
                ddlzona.Visible = true;
                ddlchofer.Visible = true;
                ddlservicio.Visible = true;
                ddlunidad.Visible = true;
                ddltipoUnidad.Visible = true;
                txtcodigo.Enabled = false;
                Bgrabar.Visible = true;
                Blimpiar.Visible = true;
                ddlnombre.Visible = true;
                lblnombre.Visible = true;
                lbldestino.Visible = true;
                lblciudadela.Visible = true;
                ddlciudadela.Visible = true;
                lbldireccionllegada.Visible = true;
                ddlnombre.Enabled = true;
                txtdireccionllegada.Enabled = true;
                ddlzonallegada.Enabled = true;
                ddlciudadelallegada.Enabled = true;
                txtestado.Enabled = true;
                ddlciudadela.Enabled = true;
                txtdireccion.Enabled = true;
                txtdistancia.Enabled = true;
                txtestadocarrera.Enabled = true;
                txtfecha.Enabled = true;
                txtvalor.Enabled = true;
                ddlchofer.Enabled = true;
                ddlservicio.Enabled = true;
                ddltipoUnidad.Enabled = true;
                ddlunidad.Enabled = true;
                ddlzona.Enabled = true;



                lblmensaje.Text = "";
                Session["codi"] = txtcodigo.Text;
                Session["modo"] = "M";

            }
            else
            {
                txtdireccionllegada.Visible = true;
                ddlzonallegada.Visible = true;
                ddlciudadelallegada.Visible = true;
                lblciudadelallegada.Visible = true;
                lblzona1.Visible = true;
                lblcodigo.Visible = true;
                lblchfofer.Visible = true;
                lbldireccion.Visible = true;
                lbldistancia.Visible = true;
                lblfecha.Visible = true;
                lblservicio.Visible = true;
                lbltipoUnidad.Visible = true;
                lblunidad.Visible = true;
                lblvalor.Visible = true;
                lblzona.Visible = true;
                lblestadocarrera.Visible = true;
                txtcodigo.Visible = true;
                txtdireccion.Visible = true;
                txtdistancia.Visible = true;
                txtestadocarrera.Visible = true;
                txtfecha.Visible = true;
                txtvalor.Visible = true;
                ddlchofer.Visible = false;
                ddlservicio.Visible = false;
                ddltipoUnidad.Visible = false;
                ddlunidad.Visible = false;
                ddlzona.Visible = false;
                Bgrabar.Visible = false;
                ddlzona.Visible = true;
                ddlchofer.Visible = true;
                ddlservicio.Visible = true;
                ddlunidad.Visible = true;
                ddltipoUnidad.Visible = true;
                txtcodigo.Enabled = false;
                Bgrabar.Visible = true;
                Blimpiar.Visible = true;
                ddlnombre.Visible = true;
                lblnombre.Visible = true;
                lbldestino.Visible = true;
                lblciudadela.Visible = true;
                ddlciudadela.Visible = true;
                lbldireccionllegada.Visible = true;
                txtcodigo.Enabled = false;
                Bgrabar.Visible = true;
                Blimpiar.Visible = true;

                txtdireccionllegada.Visible = true;
                ddlzonallegada.Visible = true;
                ddlciudadelallegada.Visible = true;
                lblciudadelallegada.Visible = true;
                lblzona1.Visible = true;
                ddlnombre.Enabled = false;
                txtdireccionllegada.Enabled = false;
                ddlzonallegada.Enabled = false;
                ddlciudadelallegada.Enabled = false;
                txtestado.Enabled = false;
                ddlciudadela.Enabled = false;
                txtdireccion.Enabled = false;
                txtdistancia.Enabled = false;
                txtestadocarrera.Enabled = false;
                txtfecha.Enabled = false;
                txtvalor.Enabled = false;
                ddlchofer.Enabled = false;
                ddlservicio.Enabled = false;
                ddltipoUnidad.Enabled = false;
                ddlunidad.Enabled = false;
                ddlzona.Enabled = false;
                Session["modo"] = "E";
                lblmensaje.Text = "Esta seguro que desea eliminar el registro?";

            }

        }

        protected void Bgrabar_Click(object sender, EventArgs e)
        {

            int numero_registro = 0;

            clase_general general = new clase_general();
            numero_registro = general.ins_updatecarreras(Convert.ToInt32(Session["codi"]), ddlnombre.SelectedValue, Convert.ToDecimal(txtdistancia.Text), txtdireccion.Text, Convert.ToInt32(ddlzona.SelectedValue), Convert.ToDecimal(txtvalor.Text), txtfecha.Text, Convert.ToInt32(ddlunidad.SelectedValue), Convert.ToInt32(ddlservicio.SelectedValue), Convert.ToInt32(ddltipoUnidad.SelectedValue), txtestadocarrera.Text, txtestado.Text, ddlchofer.SelectedValue);

        }

        protected void ddlzona_SelectedIndexChanged(object sender, EventArgs e)
        {


            txtdireccionllegada.Visible = true;
            ddlzonallegada.Visible = true;
            ddlciudadelallegada.Visible = true;
            lblciudadelallegada.Visible = true;
            lblzona1.Visible = true;
            lblcodigo.Visible = true;
            lblchfofer.Visible = true;
            lbldireccion.Visible = true;
            lbldistancia.Visible = true;
            lblfecha.Visible = true;
            lblservicio.Visible = true;
            lbltipoUnidad.Visible = true;
            lblunidad.Visible = true;
            lblvalor.Visible = true;
            lblzona.Visible = true;
            lblestadocarrera.Visible = true;
            txtcodigo.Visible = true;
            txtdireccion.Visible = true;
            txtdistancia.Visible = true;
            txtestadocarrera.Visible = true;
            txtfecha.Visible = true;
            txtvalor.Visible = true;
            ddlchofer.Visible = false;
            ddlservicio.Visible = false;
            ddltipoUnidad.Visible = false;
            ddlunidad.Visible = false;
            ddlzona.Visible = false;
            Bgrabar.Visible = false;
            ddlzona.Visible = true;
            ddlchofer.Visible = true;
            ddlservicio.Visible = true;
            ddlunidad.Visible = true;
            ddltipoUnidad.Visible = true;
            txtcodigo.Enabled = false;
            Bgrabar.Visible = true;
            Blimpiar.Visible = true;
            ddlnombre.Visible = true;
            lblnombre.Visible = true;
            lbldestino.Visible = true;
            lblciudadela.Visible = true;
            ddlciudadela.Visible = true;
            lbldireccionllegada.Visible = true;
            clase_general general = new clase_general();
            DataSet d10 = general.consulta_ciudadela(Convert.ToInt32(ddlzona.SelectedValue));
            ddlciudadela.DataSource = d10.Tables[0].DefaultView;
            ddlciudadela.DataValueField = "codigo";
            ddlciudadela.DataTextField = "ciudadela";
            ddlciudadela.DataBind();
        }

        protected void ddlzonallegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdireccionllegada.Visible = true;
            ddlzonallegada.Visible = true;
            ddlciudadelallegada.Visible = true;
            lblciudadelallegada.Visible = true;
            lblzona1.Visible = true;
            lblcodigo.Visible = true;
            lblchfofer.Visible = true;
            lbldireccion.Visible = true;
            lbldistancia.Visible = true;
            lblfecha.Visible = true;
            lblservicio.Visible = true;
            lbltipoUnidad.Visible = true;
            lblunidad.Visible = true;
            lblvalor.Visible = true;
            lblzona.Visible = true;
            lblestadocarrera.Visible = true;
            txtcodigo.Visible = true;
            txtdireccion.Visible = true;
            txtdistancia.Visible = true;
            txtestadocarrera.Visible = true;
            txtfecha.Visible = true;
            txtvalor.Visible = true;
            ddlchofer.Visible = false;
            ddlservicio.Visible = false;
            ddltipoUnidad.Visible = false;
            ddlunidad.Visible = false;
            ddlzona.Visible = false;
            Bgrabar.Visible = false;
            ddlzona.Visible = true;
            ddlchofer.Visible = true;
            ddlservicio.Visible = true;
            ddlunidad.Visible = true;
            ddltipoUnidad.Visible = true;
            txtcodigo.Enabled = false;
            Bgrabar.Visible = true;
            Blimpiar.Visible = true;
            ddlnombre.Visible = true;
            lblnombre.Visible = true;
            lbldestino.Visible = true;
            lblciudadela.Visible = true;
            ddlciudadela.Visible = true;
            lbldireccionllegada.Visible = true;



            clase_general general = new clase_general();
            DataSet d11 = general.consulta_ciudadela(Convert.ToInt32(ddlzonallegada.SelectedValue));
            ddlciudadelallegada.DataSource = d11.Tables[0].DefaultView;
            ddlciudadelallegada.DataValueField = "codigo";
            ddlciudadelallegada.DataTextField = "ciudadela";
            ddlciudadelallegada.DataBind();
        }
    }
}