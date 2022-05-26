using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormAddBook : Form
    {
        public HomeForm homeForm;
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resetFileds()
        {
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxEditor.Text = "";
            textBoxNumberExemplar.Text = "";
            textBoxYear.Text = "";
            radioButtonBiografy.Checked = false;
            radioButtonChildren.Checked = false;
            radioButtonSpeciality.Checked = false;
            radioButtonFiction.Checked = false;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (radioButtonChildren.Checked == true) n = 1;
            if (radioButtonFiction.Checked == true) n = 2;
            if (radioButtonBiografy.Checked == true) n = 3;
            if (radioButtonSpeciality.Checked == true) n = 4;

            bool title, autor, editor, an, nrexem, radio = false;


            if (textBoxTitle.Text == "" || textBoxTitle.Text.Length < 3)
            {
                errorProvider1.SetError(this.textBoxTitle, "Introduceți titul carții");
                labelMessageStatus.Text = "";
                title = false;
            }
            else { errorProvider1.Clear(); title = true; }

            if (textBoxAuthor.Text == "" || textBoxAuthor.Text.Length < 3)
            {
                errorProvider2.SetError(this.textBoxAuthor, "Introduceți autorul carții");
                labelMessageStatus.Text = "";
                autor = false;
            }
            else { errorProvider2.Clear(); autor = true; }

            if (textBoxEditor.Text == "" || textBoxEditor.Text.Length < 3)
            {
                errorProvider3.SetError(this.textBoxEditor, "Introduceți editura carții");
                labelMessageStatus.Text = "";
                editor = false;
            }
            else { errorProvider3.Clear(); editor = true; }

            if (textBoxYear.Text == "" || (Int32.Parse(textBoxYear.Text) > 2022 && Int32.Parse(textBoxYear.Text)<1899))
            {
                errorProvider4.SetError(this.textBoxYear, "Introduceți anul publicării");
                labelMessageStatus.Text = "";
                an = false;
            }
            else { errorProvider4.Clear(); an = true; }

            if (textBoxNumberExemplar.Text == "" || Int32.Parse(textBoxNumberExemplar.Text) < 0)
            {
                errorProvider6.SetError(this.textBoxNumberExemplar, "Introduceți numărul de exemplare");
                labelMessageStatus.Text = "";
                nrexem = false;
            }
            else { errorProvider6.Clear(); nrexem = true; }

            if (radioButtonChildren.Checked == false && radioButtonBiografy.Checked == false && radioButtonFiction.Checked == false && radioButtonSpeciality.Checked == false)
            {
                errorProvider5.SetError(this.label6, "Selectați genul carții");
                labelMessageStatus.Text = "";
                radio = false;
            }
            else { errorProvider5.Clear(); radio = true; }
            
            if(title == true && autor == true && editor == true && an == true && nrexem == true && radio == true)
            {
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Carte adaugata cu succes!";
                labelMessageStatus.ForeColor = Color.White;
                HomeForm.listaCarti.Add(new Carte(textBoxTitle.Text, textBoxAuthor.Text, textBoxEditor.Text, Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(textBoxNumberExemplar.Text), n));
                Console.WriteLine(HomeForm.listaCarti[0]);
                resetFileds();
         
            }
        }
    }
}
