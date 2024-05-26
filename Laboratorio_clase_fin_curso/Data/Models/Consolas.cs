using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_clase_fin_curso.Data.Models
{
    public class Consolas
    {
        private string connectionString = "Server=localhost; Database=db_universidad;Uid=root;Pwd = MATEOHERNANDEZ0909/h ";
        public int ID { get; set; }
        public string Nombre_consola { get; set; }
        public string Compania { get; set; }
        public int Anio_lanzamiento { get; set; }
        public int Generacion { get; set; }

        public Consolas() { }

        public Consolas(int id, string nombre_consola, string compania, int anio_lanzamiento, int generacion)
        {
            ID = id;
            Nombre_consola = nombre_consola;
            Compania = compania;
            Anio_lanzamiento = anio_lanzamiento;
            Generacion = generacion;
        }
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
      
    }
}
