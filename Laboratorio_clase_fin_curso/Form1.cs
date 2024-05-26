using Laboratorio_clase_fin_curso.Data;
using Laboratorio_clase_fin_curso.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Laboratorio_clase_fin_curso
{
    public partial class Form1 : Form
    {
        private Consolas Cargar;
        ConexionMySql CLS = new ConexionMySql();
        Consolas cnsls = new Consolas();
        List<Consolas> todas = new List<Consolas>();
        ClsCursor cursor1 = new ClsCursor();

        public Form1()
        {
            InitializeComponent();
            Cargar = new Consolas();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            todas = CLS.ObtenerTodasConsolas();
            dataGridView1.DataSource = todas;

            if (todas.Count > 0)
            {
                cursor1.totalRegistros = todas.Count;
                MessageBox.Show("Total De Registros:" + cursor1.totalRegistros);

            }
            else
            {
                MessageBox.Show("No hay registros");

            }
        }

        private void botonPrueba_Click(object sender, EventArgs e)
        {
            if (Cargar.ProbarConexion())
            {
                MessageBox.Show("Conexion establecida!");
            }
            else
            {
                MessageBox.Show("No se establecio conexión");
            }
        }

        private void MostrarRegistroConsolas()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.totalRegistros)
            {
                Consolas c = todas[cursor1.current];
                textBoxID.Text = c.ID.ToString();
                textBoxNombre.Text = c.Nombre_consola;
                textBoxCompania.Text = c.Compania;
                textBoxAnio.Text = c.Anio_lanzamiento.ToString();

                //incrementar el cursor y validar que no se pase del total de registros
                cursor1.current++;
                if (cursor1.current >= cursor1.totalRegistros)
                {
                    cursor1.current = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            MostrarRegistroConsolas();
        }
    }
}
