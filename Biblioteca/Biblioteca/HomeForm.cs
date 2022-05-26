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
    public partial class HomeForm : Form
    {
        public static List<Carte> listaCarti;
        public static List<Persoana> listaPersoana;
        public HomeForm()
        {
            InitializeComponent();
            listaCarti = new List<Carte>();
            listaPersoana = new List<Persoana>();
            citireFisier();
            citireFisierPersoane();
        }
        private void citireFisier()
        {
            StreamReader s = new StreamReader("carti.txt");
            String line = "";

            while ((line = s.ReadLine()) != null)
            {
                string[] p = line.Split(',');
                HomeForm.listaCarti.Add(new Carte(p[0], p[1], p[2], Convert.ToInt32(p[3]), Convert.ToInt32(p[4]), Convert.ToInt32(p[5])));
            }
            s.Close();
        }

        private void citireFisierPersoane()
        {
            StreamReader s = new StreamReader("persoane.txt");
            String line = "";

            while ((line = s.ReadLine()) != null)
            {
                string[] p = line.Split(',');
                HomeForm.listaPersoana.Add(new Persoana(p[0], p[1], Convert.ToInt32(p[2]), Convert.ToInt32(p[3]), p[4], p[5], Convert.ToInt32(p[6])));
            }
            s.Close();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Program creat de: Huțan Alina, 3133b", "Informații", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook f = new FormAddBook();
            f.homeForm = this;
            f.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.homeForm = this;
            s.Show();
        }

        private void buttonAddPeople_Click(object sender, EventArgs e)
        {
            FormAddPeople f = new FormAddPeople();
            f.homeForm = this;
            f.Show();
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            ModificaCarte m = new ModificaCarte();
            m.homeForm = this;
            m.Show();
        }
    }
}
