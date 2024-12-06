using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CRUD_DatosPersona
{
    public class PersonaDAL
    {
        public static int AgregarPersona(Persona persona)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerLaConexion())
            {
                string query = "insert into persona (nombre,edad,celular) values('" + persona.nombre + "', " + persona.edad + ", '" + persona.celular + "')";
                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();
                conexion.Close();
            }

            return retorna;
        }

        public static int ModificarPersona(Persona persona)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerLaConexion())
            {
                string query = "update persona set nombre ='" + persona.nombre + "', edad= " + persona.edad + ", celular= '" + persona.celular + "' where id= "+persona.id+"  ";
                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();
                conexion.Close();
            }
            
            return retorna;
        }

        public static int EliminarPersona(int id)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerLaConexion())
            {
                string query = "delete from persona where id=" + id + " ";
                SqlCommand command = new SqlCommand(query, conexion);
                retorna = command.ExecuteNonQuery();
                conexion.Close();
            }
            
            return retorna;
        }

        public static List<Persona> MostrarDatos()
        {
            List<Persona> Listapersonas = new List<Persona>();

            using (SqlConnection conexion = BDGeneral.ObtenerLaConexion())
            {
                string query = "select *from Persona";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.id = reader.GetInt32(0);
                    persona.nombre = reader.GetString(1);
                    persona.edad = reader.GetInt32(2);
                    persona.celular = reader.GetString(3);
                    Listapersonas.Add(persona);
                }
                conexion.Close();
                return Listapersonas;
            }
        }
    }
}
