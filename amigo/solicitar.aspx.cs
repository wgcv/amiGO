using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace amigo
{
    public partial class solicitar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


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
    }
}