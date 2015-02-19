using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace amigo
{
    public class clase_general
    {

        public DataSet consulta_zona()
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            string nombre_procedimiento = "consulta_zona";
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet consulta_tipoUnidad()
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            string nombre_procedimiento = "consulta_tipounidad";
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet consulta_ciudadela(int codigo)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            string nombre_procedimiento = "consulta_ciudadela";
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            da.SelectCommand.Parameters.Add(p_codigo);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet consulta_usuario()
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            string nombre_procedimiento = "consulta_usuario";
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int inserta_usuario(string UserId, string nombre, string apellido, int celular)
        {

            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "inserta_usuario";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_userId = new SqlParameter("@UserId", UserId);
            SqlParameter p_nombre = new SqlParameter("@nombre", nombre);
            p_nombre.Size = 50;
            SqlParameter p_apellido = new SqlParameter("@apellido", apellido);
            p_apellido.Size = 50;
            SqlParameter p_celular = new SqlParameter("@celular", celular);
            p_celular.Size = 4;

            comando.Parameters.Add(p_userId);
            comando.Parameters.Add(p_nombre);
            comando.Parameters.Add(p_apellido);
            comando.Parameters.Add(p_celular);

            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;

        }
        public int ins_updatechofer(string UserId,int codigo,string tipolicencia, string cedula, string nombre, string horaentrada, string horasalida, string telefono, string estado, string disponible)
        {

            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "sp_Chofer_ins_upd";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            SqlParameter p_tipolicencia = new SqlParameter("@tipolicencia", tipolicencia);
            p_tipolicencia.Size = 1;
            SqlParameter p_cedula = new SqlParameter("@cedula", cedula);
            p_cedula.Size = 15;
            SqlParameter p_nombre = new SqlParameter("@nombre", nombre);
            p_nombre.Size = 50;
            SqlParameter p_horaentrada = new SqlParameter("@horaEntrada", horaentrada);
            SqlParameter p_horasalida = new SqlParameter("@horaSalida", horasalida);
            SqlParameter p_telefono = new SqlParameter("@telefono", telefono);
            p_telefono.Size = 15;
            SqlParameter p_userId = new SqlParameter("@UserId", UserId);
            SqlParameter p_estado = new SqlParameter("@estado", estado);
            p_estado.Size = 1;
            SqlParameter p_disponible = new SqlParameter("@disponible", disponible);
            p_disponible.Size = 1;
        
            comando.Parameters.Add(p_codigo);
            comando.Parameters.Add(p_tipolicencia);
            comando.Parameters.Add(p_cedula);
            comando.Parameters.Add(p_nombre);
            comando.Parameters.Add(p_horaentrada);
            comando.Parameters.Add(p_horasalida);
            comando.Parameters.Add(p_telefono);
            comando.Parameters.Add(p_userId);
            comando.Parameters.Add(p_estado);
            comando.Parameters.Add(p_disponible);
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;

        }
        public DataSet consulta_chofer(string tipo_consulta, string tipo, string valor)
        {
            string nombre_procedimiento = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            if (tipo_consulta == "G")
            {

                nombre_procedimiento = "general_chofer";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            else
            {
                nombre_procedimiento = "especifica_chofer";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(nombre_procedimiento, conexion);

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter p_band = new SqlParameter("@band", tipo);
                p_band.Size = 20;
                SqlParameter p_tipo = new SqlParameter("@tipo", valor);
                p_tipo.Size = 50;

                adapter.SelectCommand.Parameters.Add(p_band);
                adapter.SelectCommand.Parameters.Add(p_tipo);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
        public int elimina_chofer(int codigo)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "elimina_chofer";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            comando.Parameters.Add(p_codigo);
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;
        }
        public DataSet consulta_unidades(string tipo_consulta, string tipo, string valor)
         {string nombre_procedimiento = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            if (tipo_consulta == "G")
            {

                nombre_procedimiento = "general_unidades";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            else
            {
                nombre_procedimiento = "especifica_unidades";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(nombre_procedimiento, conexion);

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter p_band = new SqlParameter("@band", tipo);
                p_band.Size = 20;
                SqlParameter p_tipo = new SqlParameter("@tipo", valor);
                p_tipo.Size = 50;

                adapter.SelectCommand.Parameters.Add(p_band);
                adapter.SelectCommand.Parameters.Add(p_tipo);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
        public int ins_updateunidades(int codigo,string modelo, string marca, int ano, string placa, decimal valorKm, int zona, int chofer, int tipoUnidad, string estado, string disponible)
         {

             ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
             string cadena_conexion = param.ConnectionString;
             SqlConnection conexion = new SqlConnection(cadena_conexion);
             conexion.Open();
             string nombre_procedimiento = "sp_unidades_ins_upd";
             SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
             comando.CommandType = CommandType.StoredProcedure;
             SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
             p_codigo.Size = 4;
             SqlParameter p_modelo = new SqlParameter("@modelo", modelo);
             p_modelo.Size = 150;
             SqlParameter p_marca = new SqlParameter("@marca", marca);
             p_marca.Size = 150;
             SqlParameter p_ano = new SqlParameter("@ano", ano);
             p_ano.Size = 4;
             SqlParameter p_placa = new SqlParameter("@placa", placa);
             p_placa.Size = 10;
             SqlParameter p_valorKm = new SqlParameter("@valorKm", valorKm);
             p_valorKm.Size = 8;
             SqlParameter p_zona = new SqlParameter("@zona", zona);
             p_zona.Size = 4;
             SqlParameter p_chofer = new SqlParameter("@chofer", chofer);
             p_chofer.Size = 4;
             SqlParameter p_tipoUnidad = new SqlParameter("@tipoUnidad", tipoUnidad);
             p_tipoUnidad.Size = 4;
             SqlParameter p_estado = new SqlParameter("@estado", estado);
             p_estado.Size = 1;
             SqlParameter p_disponible = new SqlParameter("@disponible", disponible);
             p_disponible.Size = 1;

             comando.Parameters.Add(p_codigo);
             comando.Parameters.Add(p_modelo);
             comando.Parameters.Add(p_marca);
             comando.Parameters.Add(p_ano);
             comando.Parameters.Add(p_placa);
             comando.Parameters.Add(p_valorKm);
             comando.Parameters.Add(p_zona);
             comando.Parameters.Add(p_chofer);
             comando.Parameters.Add(p_tipoUnidad);
             comando.Parameters.Add(p_estado);
             comando.Parameters.Add(p_disponible);
             int numero_registro = comando.ExecuteNonQuery();
             conexion.Close();
             return numero_registro;

         }
        public int elimina_unidades(int codigo)
         {
             ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
             string cadena_conexion = param.ConnectionString;
             SqlConnection conexion = new SqlConnection(cadena_conexion);
             conexion.Open();
             string nombre_procedimiento = "elimina_cunidades";
             SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
             comando.CommandType = CommandType.StoredProcedure;
             SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
             p_codigo.Size = 4;
             comando.Parameters.Add(p_codigo);
             int numero_registro = comando.ExecuteNonQuery();
             conexion.Close();
             return numero_registro;
         }
        public DataSet consulta_servicios(string tipo_consulta, string tipo, string valor)
         {
             string nombre_procedimiento = "";
             ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
             string cadena_conexion = param.ConnectionString;
             if (tipo_consulta == "G")
             {

                 nombre_procedimiento = "general_servicios";
                 SqlConnection conexion = new SqlConnection(cadena_conexion);
                 SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
                 da.SelectCommand.CommandType = CommandType.StoredProcedure;
                 DataSet ds = new DataSet();
                 da.Fill(ds);
                 return ds;
             }
             else
             {
                 nombre_procedimiento = "especifica_servicios";
                 SqlConnection conexion = new SqlConnection(cadena_conexion);
                 SqlDataAdapter adapter = new SqlDataAdapter(nombre_procedimiento, conexion);

                 adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                 SqlParameter p_band = new SqlParameter("@band", tipo);
                 p_band.Size = 20;
                 SqlParameter p_tipo = new SqlParameter("@tipo", valor);
                 p_tipo.Size = 50;

                 adapter.SelectCommand.Parameters.Add(p_band);
                 adapter.SelectCommand.Parameters.Add(p_tipo);
                 DataSet ds = new DataSet();
                 adapter.Fill(ds);
                 return ds;
             }
         }
        public int ins_updateservicios(int codigo,string servicio, decimal valor, string estado)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "sp_servicios_ins_upd";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_servicio = new SqlParameter("@servicio", servicio);
            p_servicio.Size = 150;
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            SqlParameter p_valor = new SqlParameter("@valor", valor);
            p_valor.Size = 6;
            SqlParameter p_estado = new SqlParameter("@estado", estado);
            p_estado.Size = 1;
            comando.Parameters.Add(p_codigo);
            comando.Parameters.Add(p_servicio);
            comando.Parameters.Add(p_valor);
            comando.Parameters.Add(p_estado);
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;

        }
        public int elimina_servicios(int codigo)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "elimina_servicios";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            comando.Parameters.Add(p_codigo);
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;
        }
        public DataSet consulta_tipounidad(string tipo_consulta, string tipo, string valor)
        {
            string nombre_procedimiento = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            if (tipo_consulta == "G")
            {

                nombre_procedimiento = "general_tipounidad";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            else
            {
                nombre_procedimiento = "especifica_tipounidades";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(nombre_procedimiento, conexion);

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter p_band = new SqlParameter("@band", tipo);
                p_band.Size = 20;
                SqlParameter p_tipo = new SqlParameter("@tip", valor);
                p_tipo.Size = 50;

                adapter.SelectCommand.Parameters.Add(p_band);
                adapter.SelectCommand.Parameters.Add(p_tipo);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
        public int ins_updatetipounidad(int codigo, string tipo, string estado)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "sp_tipoUnidades_ins_upd";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            SqlParameter p_tipo = new SqlParameter("@tipo", tipo);
            p_tipo.Size = 150;
            SqlParameter p_estado = new SqlParameter("@estado", estado);
            p_estado.Size = 1;
            comando.Parameters.Add(p_codigo);
            comando.Parameters.Add(p_tipo);
            comando.Parameters.Add(p_estado);
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;

        }
        public int elimina_tipounidad(int codigo)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "elimina_tipounidad";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            comando.Parameters.Add(p_codigo);
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;
        }
        public DataSet consulta_comentarios()
        {
            string nombre_procedimiento = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
           
                nombre_procedimiento = "general_comentarios";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        public int elimina_comentarios(int codigo)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "elimina_comentarios";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            comando.Parameters.Add(p_codigo);
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;
        }
        public DataSet consulta_contactanos(string tipo_consulta, string tipo, string valor)
        {
            string nombre_procedimiento = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            if (tipo_consulta == "G")
            {

                nombre_procedimiento = "general_contactanos";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            else
            {
                nombre_procedimiento = "especifica_contactanos";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(nombre_procedimiento, conexion);

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter p_band = new SqlParameter("@band", tipo);
                p_band.Size = 20;
                SqlParameter p_tipo = new SqlParameter("@tipo", valor);
                p_tipo.Size = 50;

                adapter.SelectCommand.Parameters.Add(p_band);
                adapter.SelectCommand.Parameters.Add(p_tipo);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
        public int elimina_contactanos(int codigo)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "elimina_contactanos";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_codigo = new SqlParameter("@codigo", codigo);
            p_codigo.Size = 4;
            comando.Parameters.Add(p_codigo);
            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;
        }
        public DataSet consulta_carreras()
        {
            string nombre_procedimiento = "";
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            //if (tipo_consulta == "G")
            // {

            nombre_procedimiento = "general_carreras";
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            SqlDataAdapter da = new SqlDataAdapter(nombre_procedimiento, conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
            // }
            /*else
            {
                nombre_procedimiento = "especifica_unidades";
                SqlConnection conexion = new SqlConnection(cadena_conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(nombre_procedimiento, conexion);

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter p_band = new SqlParameter("@band", tipo);
                p_band.Size = 20;
                SqlParameter p_tipo = new SqlParameter("@tipo", valor);
                p_tipo.Size = 50;

                adapter.SelectCommand.Parameters.Add(p_band);
                adapter.SelectCommand.Parameters.Add(p_tipo);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }*/
        }
        public int ins_updatecarreras(int id, string UserId, decimal km, string direccion, int zona, decimal valorAprox, string fecha, int unidad, int servicio, int tipoUnidad, string activa, string estado, string ChoferId)
        {
            ConnectionStringSettings param = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            string cadena_conexion = param.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();
            string nombre_procedimiento = "sp_registroCarrera_ins_upd";
            SqlCommand comando = new SqlCommand(nombre_procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter p_id = new SqlParameter("@id", id);
            p_id.Size = 4;
            SqlParameter p_UserId = new SqlParameter("@UserId", UserId);
            SqlParameter p_km = new SqlParameter("@km", km);
            p_km.Size = 8;
            SqlParameter p_direccion = new SqlParameter("@direccion", direccion);
            p_direccion.Size = 8;
            SqlParameter p_zona = new SqlParameter("@zona ", zona);
            p_zona.Size = 150;
            SqlParameter p_valorAprox = new SqlParameter("@valorAprox ", valorAprox);
            p_valorAprox.Size = 150;
            SqlParameter p_fecha = new SqlParameter("@fecha ", fecha);
            p_fecha.Size = 150;
            SqlParameter p_unidad = new SqlParameter("@unidad", unidad);
            p_unidad.Size = 4;
            SqlParameter p_servicio = new SqlParameter("@servicio", servicio);
            p_servicio.Size = 4;
            SqlParameter p_tipoUnidad = new SqlParameter("@tipoUnidad", tipoUnidad);
            p_tipoUnidad.Size = 4;
            SqlParameter p_activa = new SqlParameter("@activa", activa);
            p_activa.Size = 4;
            SqlParameter p_estado = new SqlParameter("@estado", estado);
            p_estado.Size = 1;
            SqlParameter p_ChoferId = new SqlParameter("@ChoferId", ChoferId);


            comando.Parameters.Add(p_id);
            comando.Parameters.Add(p_UserId);
            comando.Parameters.Add(p_km);
            comando.Parameters.Add(p_direccion);
            comando.Parameters.Add(p_zona);
            comando.Parameters.Add(p_valorAprox);
            comando.Parameters.Add(p_fecha);
            comando.Parameters.Add(p_unidad);
            comando.Parameters.Add(p_servicio);
            comando.Parameters.Add(p_tipoUnidad);
            comando.Parameters.Add(p_activa);
            comando.Parameters.Add(p_estado);
            comando.Parameters.Add(p_ChoferId);

            int numero_registro = comando.ExecuteNonQuery();
            conexion.Close();
            return numero_registro;

        }
       
    }
}