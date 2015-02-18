using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace amigo.Account
{
    public partial class whatsapp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int numero_registro = 0;
            MembershipUser u;
            u = System.Web.Security.Membership.GetUser();
            clase_general general = new clase_general();
            numero_registro = general.inserta_usuario(u.ProviderUserKey.ToString(), txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtCelular.Text));
            Response.Redirect("default.aspx");
        }


    }
}