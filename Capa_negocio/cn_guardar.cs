using Capa_datos;
//using CapaDatos;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Capa_negocio
{
    public class CN_Guardar : ConexionDatos
    {
        public bool InsertarUsuario(string nombre, string apellido, string direccion)
        {

            //El Try Catch es para capturar un error con la conexion a la base de datos, la instruction connectionString no estaba funcionando porque 
            //no se estaba llamando a la clase ConexionDatos, por eso se heredo en esta clase, de esa forma empezó a reconocerla y se pudo establecer la conexion
            //con la base de datos
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    //En esta parte se usa una consulta SQL para insertar datos en la base de datos y  se usan parametros para evitar inyecciones SQL,
                    //la inyeccion SQL es un ataque que se hace a traves de formularios, se inserta codigo SQL en los campos de texto y se puede acceder
                    //a la base de datos, por eso es importante usar parametros para evitar este tipo de ataques y establecer una conexion segura

                    string query = "INSERT INTO [gestor] (Nombre, Apellido, Direccion) VALUES (@Nombre, @Apellido,@Direccion)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
                        cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = apellido;
                        cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = direccion;

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message, ex);
            }
        }
    }
}