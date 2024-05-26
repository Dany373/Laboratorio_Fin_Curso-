﻿using Laboratorio_clase_fin_curso.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_clase_fin_curso.Data
{
    internal class ConexionMySql
    {
        string connectionString = "Server=localhost; Database=db_universidad;Uid=root;Pwd = MATEOHERNANDEZ0909/h ";
        MySqlConnection connection;


        //constructor
        public ConexionMySql()
        {
            connection = new MySqlConnection(connectionString);
        }

        
        public List<Consolas> ObtenerTodasConsolas()
        {
            List<Consolas> consolas = new List<Consolas>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM catalogo_consolas";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    

                    while (reader.Read())
                    {
                        Consolas consola = new Consolas
                        (
                            id: reader.GetInt32("ID"),
                            nombre_consola: reader.GetString("Nombre"),
                            compania: reader.GetString("Compania"),
                            anio_lanzamiento: reader.GetInt32("Anio_lanzamiento"),
                            generacion: reader.GetInt32("Generacion")

                            );
                            

                        consolas.Add(consola);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return consolas;
        }
        }
    }
