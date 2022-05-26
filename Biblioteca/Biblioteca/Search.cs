using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Search : Form
    {
        public HomeForm homeForm;
        public Search()
        {
            InitializeComponent();
         
            dataGridView1.DataSource = HomeForm.listaCarti.ToList();
            dataGridView2.DataSource = HomeForm.listaPersoana.ToList();
        }

        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            List<Carte> lista = new List<Carte>();
            foreach (Carte c in HomeForm.listaCarti) {
                if (c.DataActualizare > dateTimePicker1.Value && c.DataActualizare< dateTimePicker2.Value)
                {
                    lista.Add(c);
                }
            }

            dataGridView1.DataSource = lista.ToList();
   
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Persoana> lista = new List<Persoana>();
            foreach (Persoana c in HomeForm.listaPersoana)
            {
                if (c.DataActualizare > dateTimePicker1.Value && c.DataActualizare < dateTimePicker2.Value)
                {
                    lista.Add(c);
                }
            }

            dataGridView2.DataSource = lista.ToList();
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                HomeForm.listaCarti.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dataGridView1.DataSource = HomeForm.listaCarti.ToList();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeForm.listaPersoana.RemoveAt(dataGridView2.SelectedRows[0].Index);
            
            dataGridView2.DataSource = HomeForm.listaPersoana.ToList();
        }
    }
}
