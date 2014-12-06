using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;
using System.Data.SqlClient;

namespace amigo
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }


        protected void btnComentario_Click(object sender, EventArgs e)
        {
            MembershipUser u;
            u = System.Web.Security.Membership.GetUser();
            if (u != null)
            {
                ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
                string cadenaConexion = param.ConnectionString;
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                string sql = "INSERT INTO comentarios (mensaje, nombre,idUsuario,visible) VALUES('" + txtComentario.Text + "','" + u.UserName + "','" + u.ProviderUserKey.ToString() +"','T')";
                SqlCommand commando = new SqlCommand(sql, conexion);
                conexion.Open();
                int numeo_registro = commando.ExecuteNonQuery();
                conexion.Close();
                //lblIdUSuario.Text = u.ProviderUserKey.ToString();
                txtComentario.Visible = false;
                btnComentario.Visible = false;
                lblcomentarios.Text = txtComentario.Text;
                lblCusuario.Text = u.UserName;
                lblMensajeComentario.Text = "Se ha enviado el comentario, gracias";

            }
            else {
                lblMensajeComentario.Text = "Debe estar registrado para dejar un comentario!";
            }
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        protected void lblcomentarios_Click(object sender, EventArgs e)
        {
        }
>>>>>>> parent of 7c44154... Revert "'lpzxvjciohuf"
=======
        protected void lblcomentarios_Click(object sender, EventArgs e)
        {
        }
>>>>>>> parent of 7c44154... Revert "'lpzxvjciohuf"
=======
        protected void lblcomentarios_Click(object sender, EventArgs e)
        {
        }
>>>>>>> parent of 7c44154... Revert "'lpzxvjciohuf"
    }
}
