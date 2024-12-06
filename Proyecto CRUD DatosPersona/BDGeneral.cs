using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CRUD_DatosPersona
{
    public class BDGeneral
    {

        public static SqlConnection ObtenerLaConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Persona;Data Source=DESKTOP-P0VQ2DE");
            conexion.Open();
            return conexion;
        }
    }
}
