using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace amigo
{
    public partial class solicitar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                total.ReadOnly = true;

                clase_general general = new clase_general();
                DataSet ds = general.consulta_zona();
                ddlsectororigen.DataSource = ds.Tables[0].DefaultView;
                ddlsectororigen.DataValueField = "codigo";
                ddlsectororigen.DataTextField = "nombre_zona";
                ddlsectororigen.DataBind();

                ddlsectordestino.DataSource = ds.Tables[0].DefaultView;
                ddlsectordestino.DataValueField = "codigo";
                ddlsectordestino.DataTextField = "nombre_zona";
                ddlsectordestino.DataBind();


                ds = general.consulta_ciudadela(Convert.ToInt32(Int32.Parse(ddlsectororigen.SelectedValue.ToString())));
                ddlciudadelaorigen.DataSource = ds.Tables[0].DefaultView;
                ddlciudadelaorigen.DataValueField = "codigo";
                ddlciudadelaorigen.DataTextField = "ciudadela";
                ddlciudadelaorigen.DataBind();

                ds = general.consulta_ciudadela(Convert.ToInt32(Int32.Parse(ddlsectordestino.SelectedValue.ToString())));
                ddlciudadeladestino.DataSource = ds.Tables[0].DefaultView;
                ddlciudadeladestino.DataValueField = "codigo";
                ddlciudadeladestino.DataTextField = "ciudadela";
                ddlciudadeladestino.DataBind();


                ds = general.consulta_tipoUnidad();
                ddltipo.DataSource = ds.Tables[0].DefaultView;
                ddltipo.DataValueField = "codigo";
                ddltipo.DataTextField = "tipo";
                ddltipo.DataBind();

                ds = general.consulta_servicios("G","","");
                ddlservicio.DataSource = ds.Tables[0].DefaultView;
                ddlservicio.DataValueField = "codigo";
                ddlservicio.DataTextField = "nombre_servicio";
                ddlservicio.DataBind();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = total.Text;
        }

        protected void ddlsectororigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            clase_general general = new clase_general();
            DataSet ds = general.consulta_ciudadela(Convert.ToInt32(Int32.Parse(ddlsectororigen.SelectedValue.ToString())));
            ddlciudadelaorigen.DataSource = ds.Tables[0].DefaultView;
            ddlciudadelaorigen.DataValueField = "codigo";
            ddlciudadelaorigen.DataTextField = "ciudadela";
            ddlciudadelaorigen.DataBind();
        }

        protected void ddlciudadelaorigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlsectordestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            clase_general general = new clase_general();
            DataSet ds = general.consulta_ciudadela(Convert.ToInt32(Int32.Parse(ddlsectordestino.SelectedValue.ToString())));
            ddlciudadeladestino.DataSource = ds.Tables[0].DefaultView;
            ddlciudadeladestino.DataValueField = "codigo";
            ddlciudadeladestino.DataTextField = "ciudadela";
            ddlciudadeladestino.DataBind();
        }

        protected void ddlciudadeladestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnsolictar_Click(object sender, EventArgs e)
        {
               MembershipUser u;
            u = System.Web.Security.Membership.GetUser();
            
            clase_general general = new clase_general();
            DataSet ds = general.asignaUnidad(Convert.ToInt32(ddlsectororigen.SelectedValue), Convert.ToInt32(ddltipo.SelectedValue), u.ProviderUserKey.ToString(), Convert.ToInt32(ddltipo.SelectedValue));
            if (ds.Tables[0].Rows.Count < 1)
            {
                lblError.Visible = true;
            }
            else
            {
                String choferUI = ds.Tables[0].Rows[0]["UserId"].ToString();
                String choferNombre = ds.Tables[0].Rows[0]["nombre"].ToString(); // pasar
                String chofertelefono =  ds.Tables[0].Rows[0]["telefono"].ToString(); //pasar
                String carroModelo =  ds.Tables[0].Rows[0]["modelo"].ToString(); // pasar
                 String carroMarca =  ds.Tables[0].Rows[0]["marca"].ToString(); //pasar
                String carroPlaca=  ds.Tables[0].Rows[0]["placa"].ToString();//pasar
                String carrValorKm = ds.Tables[0].Rows[0]["ValorKm"].ToString(); 
                 String celular = ds.Tables[0].Rows[0]["celular"].ToString();//usar
                 String valorServicio = ds.Tables[0].Rows[0]["valor"].ToString();
                 String km = totalh.Value;
                 km = km.Replace('.', ',');


                 Decimal valor = Convert.ToDecimal(valorServicio) + (Convert.ToDecimal(km) * Convert.ToDecimal(carrValorKm));

                 Response.Write("<script type='text/javascript'>window.open('http://104.236.230.65/index.php?numero=593" + celular + "&mensaje=La unidad modelo: " + carroModelo + " Marca: " + carroMarca + " Placas: " + carroPlaca + ". El sr " + choferNombre + " llegara en unos minutos','cal','width=0,height=0,left=0,top=0');</script>");
                 Response.Write("<script type='text/javascript'>window.location.href  = '/despacho.aspx?chofer=" + choferNombre + "&telefono=" + chofertelefono + "&modelo=" + carroModelo + "&marca=" + carroMarca+ "&placa=" + carroPlaca+"';</script>");
                
                
                //Response.Redirect("/despacho.aspx?chofer=" + choferNombre + "&telefono=" + chofertelefono + "&modelo=" + carroModelo + "&marca=" + carroMarca+ "&placa=" + carroPlaca);
           
            
            }
        }
    }
}