using System;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Capa_datos;


namespace Capa_datos
{

    //Esta es la clase que se hereda en la clase creada en la capa de negocios, la parte que dice Integrated Security es para validar datos
    //con windows, y la parte de Encrypt=false es para que no se encripten los datos
    public class ConexionDatos
    {

        public string connectionString = "Data Source=.; Initial Catalog=clientando; Integrated Security=True; TrustServerCertificate=True; Encrypt=False;";
    }
}
