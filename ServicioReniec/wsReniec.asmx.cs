using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

//Declarar los namespace
using System.Data; //con base de datos
using System.Data.SqlClient; //sql server
using System.Configuration; //web config

namespace ServicioReniec
{
    /// <summary>
    /// Descripción breve de wsReniec
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsReniec : System.Web.Services.WebService
    {
        //traer la cadena de conexion desde el archivo seguro web.config
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description = "Listar los datos de la tabla datos")]
        public DataSet Listar()
        {
            string consulta = "select * from datos";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;

        }
        [WebMethod(Description = "Buscar por dni")]
        public DataSet Buscar(string bdni)
        {
            string consulta = "select * from datos where dni = '" + bdni + "'";
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }
        
    }
    
}
