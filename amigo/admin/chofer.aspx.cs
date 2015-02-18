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
            lbldisponible.Visible = false;
            txtdisponible.Visible = false;
            // lblusuario.Visible = false;
            //txtusuarioid.Visible = false;
            lblmensaje.Visible = false;
            btngrabar.Visible = false;
            btnlimpiar.Visible = false;
            if (!Page.IsPostBack)
            {
                clase_general general = new clase_general();
                DataSet ds = general.consulta_chofer("G", "", "");
                grvchofer.DataSource = ds;
                grvchofer.DataBind();



                DataSet d1 = general.consulta_usuario();
                DropDownList1.DataSource = d1.Tables[0].DefaultView;
                DropDownList1.DataValueField = "UserId";
                DropDownList1.DataTextField = "UserName";
                DropDownList1.DataBind();
            }
        }

        protected void btnnuevo_Click(object sender, EventArgs e)
        {
            txtdisponible.Enabled = true;
            txtdisponible.Visible = true;
            lbldisponible.Visible = true;
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
            Session["codi"] = 100000;
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
            clase_general general = new clase_general();
            DataSet ds = general.consulta_chofer("E", ddllist.SelectedValue, txtbuscar.Text);
            grvchofer.DataSource = ds;
            grvchofer.DataBind();
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
            txtdisponible.Visible = true;
            lbldisponible.Visible = true;

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
            txtdisponible.Text = registro.Cells[10].Text;
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
                txtdisponible.Enabled = true;
                txtdisponible.Visible = true;
                txtcodigo.Enabled = false;
                lblmensaje.Text = "";
                Session["codi"] = txtcodigo.Text;
            }
            else
            {
                txtdisponible.Enabled = false;
                txtdisponible.Visible = true;

                txttipolicencia.Enabled = false;
                txtcedula.Enabled = false;
                txtnombre.Enabled = false;
                txthoraEntrada.Enabled = false;
                txthsalida.Enabled = false;
                txttelefono.Enabled = false;
                txtestado.Enabled = false;
                btngrabar.Enabled = false;
                txtcodigo.Enabled = false;
                txtestado.Visible = true;
                txtdisponible.Visible = true;
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
            int numero_registro = 0;
            clase_general general = new clase_general();
            numero_registro = general.ins_updatechofer(Convert.ToString(DropDownList1.SelectedValue), Convert.ToInt32(Session["codi"]), txttipolicencia.Text, txtcedula.Text, txtnombre.Text, txthoraEntrada.Text, txthsalida.Text, txttelefono.Text, txtestado.Text, txtdisponible.Text);

            if (Session["modo"] == "E")
            {
                general = new clase_general();
                numero_registro = general.elimina_chofer(Convert.ToInt32(Session["codigo"]));

            }
            Response.Redirect("chofer.aspx");
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void btnrefrescar_Click(object sender, EventArgs e)
        {
            Response.Redirect("chofer.aspx");
        }




    }
}