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
    public partial class FormAddPeople : Form
    {
        public HomeForm homeForm;
        public FormAddPeople()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }

        private void resetFields()
        {
            textBoxLastName.Text = "";
            textBoxFirstName.Text = "";
            textBoxAge.Text = "";
            textBoxNumberBook.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            radioButtonElev.Checked = false;
            radioButtonStudent.Checked = false;
            radioButtonAngajat.Checked = false;
            radioButtonPensionar.Checked = false;
        }

        private void buttonAddPeople_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (radioButtonElev.Checked == true) n = 1;
            if (radioButtonStudent.Checked == true) n = 2;
            if (radioButtonAngajat.Checked == true) n = 3;
            if (radioButtonPensionar.Checked == true) n = 4;

            bool nume, prenume, varsta, nrexem, telefon, email, radio = false;


            if (textBoxLastName.Text == "" || textBoxLastName.Text.Length < 3)
            {
                errorProvider1.SetError(this.textBoxLastName, "Introduceți numele");
                labelMessageStatus.Text = "";
                nume = false;
            }
            else { errorProvider1.Clear(); nume = true; }

            if (textBoxFirstName.Text == "" || textBoxFirstName.Text.Length < 3)
            {
                errorProvider2.SetError(this.textBoxFirstName, "Introduceți prenumele");
                labelMessageStatus.Text = "";
                prenume = false;
            }
            else { errorProvider2.Clear(); prenume = true; }

            if (textBoxAge.Text == "" || Int32.Parse(textBoxAge.Text)<0 )
            {
                errorProvider3.SetError(this.textBoxAge, "Introduceți varsta");
                labelMessageStatus.Text = "";
                varsta = false;
            }
            else { errorProvider3.Clear(); varsta = true; }

            if (textBoxNumberBook.Text == "" || Int32.Parse(textBoxNumberBook.Text) < 0)
            {
                errorProvider4.SetError(this.textBoxNumberBook, "Introduceți numărul de carți");
                labelMessageStatus.Text = "";
                nrexem = false;
            }
            else { errorProvider4.Clear(); nrexem = true; }

            if (textBoxPhone.Text == "" || textBoxPhone.TextLength !=  10)
            {
                errorProvider5.SetError(this.textBoxPhone, "Introduceți un numar de telefon valid");
                textBoxPhone.Text = "";
                telefon = false;
            }
            else { errorProvider5.Clear(); telefon = true; }

            if (textBoxEmail.Text == "" || !textBoxEmail.Text.Contains("@"))
            {
                errorProvider6.SetError(this.textBoxEmail, "Introduceți un email valid");
                textBoxEmail.Text = "";
                email = false;
            }
            else { errorProvider6.Clear(); email = true; }

            if (radioButtonElev.Checked == false && radioButtonStudent.Checked == false && radioButtonAngajat.Checked == false && radioButtonPensionar.Checked == false)
            {
                errorProvider7.SetError(this.textBoxEmail, "Selectati statutul");
                labelMessageStatus.Text = "";
                radio = false;
            }
            else { errorProvider7.Clear(); radio = true; }

            if (nume == true && prenume == true && nrexem == true && varsta == true && telefon == true && email == true &&  radio == true)
            {
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Persoana adaugata cu succes!";
                labelMessageStatus.ForeColor = Color.White;
                HomeForm.listaPersoana.Add(new Persoana(textBoxLastName.Text, textBoxFirstName.Text, Convert.ToInt32(textBoxAge.Text), Convert.ToInt32(textBoxNumberBook.Text), textBoxPhone.Text, textBoxEmail.Text, n));
                Console.WriteLine(HomeForm.listaCarti[0]);
                resetFields();

            }
        }
    }
}
