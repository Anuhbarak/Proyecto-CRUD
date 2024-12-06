using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CRUD_DatosPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = textNombre.Text;
            persona.edad = Convert.ToInt32(textEdad.Text);
            persona.celular = textCelular.Text;

            int result = PersonaDAL.AgregarPersona(persona);

            if (result > 0)
            {
                MessageBox.Show("Guardado con Exito");
            }
            else
            {
                MessageBox.Show("Error al guardar Datos");
            }
            RefressScreenInfo();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            

                }
            
        
        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = textNombre.Text;
            persona.edad = Convert.ToInt32(textEdad.Text);
            persona.celular = textCelular.Text;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            persona.id = id;
                    int result = PersonaDAL.ModificarPersona(persona);

                    if (result > 0)
                    {
                        MessageBox.Show("Datos Actualizados");
                    }
                    else
                    {
                        MessageBox.Show("Error al Actualizar los Datos");
                    }


            RefressScreenInfo();
        }
                      
        
    

        
                
            
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            RefressScreenInfo();
            textId.Enabled = false;
        }
        private void RefressScreenInfo()
        {
            dataGridView1.DataSource = PersonaDAL.MostrarDatos();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            textNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            textEdad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["edad"].Value);
            textCelular.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["celular"].Value);
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textId.Clear(); 
            textNombre.Clear();
            textEdad.Clear();
            textCelular.Clear();
            dataGridView1.CurrentCell = null;
            


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            int result = PersonaDAL.EliminarPersona(id);
            if (result > 0)
            {
                MessageBox.Show("Eliminado con Exito");
            }
            else
            {
                MessageBox.Show("Error al Eliminar");
            }
            RefressScreenInfo();
        }
    }
    }

