using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace amigo.solicitar
{
    public partial class desunidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblChofer.Text = Request.QueryString["chofer"];
            lblTelefono.Text = Request.QueryString["telefono"];
            lblMarca.Text = Request.QueryString["marca"];
            lblModelo.Text = Request.QueryString["modelo"];
            lblPlacas.Text = Request.QueryString["placa"];

        }
    }
}