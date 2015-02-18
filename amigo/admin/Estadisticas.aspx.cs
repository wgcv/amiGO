using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace amigo
{
    public partial class Estadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["ApplicationServices"];//cambiar con cadena de conexion donde estan los store procedure
            string cadena_conexion = settings.ConnectionString;

            //Objeto conexion a la base de datos
            SqlConnection conn = new SqlConnection(cadena_conexion);

            //Objeto Adaptador para traer los datos
            SqlDataAdapter da = new SqlDataAdapter("TopChofer", conn);

            //Setear el tipo de comando a SP
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();

            //llenar el dataset con datos
            da.Fill(ds);


            ChtChofer.DataSource = ds.Tables[0];
            Series serie = new Series();
            serie.XValueMember = "co_chof";
            serie.YValueMembers = "cont_co_chof";

            ChtChofer.Series.Add(serie);

            ChtChofer.DataBind();

            //UNIDADES

            //Objeto Adaptador para traer los datos
            da = new SqlDataAdapter("TopUnidad", conn);

            //Setear el tipo de comando a SP
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();

            //llenar el dataset con datos
            da.Fill(ds);


            ChtUnidad.DataSource = ds.Tables[0];
            serie = new Series();
            serie.XValueMember = "unidad";
            serie.YValueMembers = "cont_unidad";

            ChtUnidad.Series.Add(serie);

            ChtUnidad.DataBind();

            //SERVICIO

            //Objeto Adaptador para traer los datos
            da = new SqlDataAdapter("TopServicio", conn);

            //Setear el tipo de comando a SP
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();

            //llenar el dataset con datos
            da.Fill(ds);


            ChtServicio.DataSource = ds.Tables[0];
            serie = new Series();
            serie.XValueMember = "servicio";
            serie.YValueMembers = "cont_servico";

            ChtServicio.Series.Add(serie);

            ChtServicio.DataBind();

            //ZONAS

            //Objeto Adaptador para traer los datos
            da = new SqlDataAdapter("TopZona", conn);

            //Setear el tipo de comando a SP
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();

            //llenar el dataset con datos
            da.Fill(ds);


            ChtZona.DataSource = ds.Tables[0];
            serie = new Series();
            serie.XValueMember = "zona";
            serie.YValueMembers = "cont_zona";

            ChtZona.Series.Add(serie);

            ChtZona.DataBind();
        }
    }
}