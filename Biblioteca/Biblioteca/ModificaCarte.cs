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
    public partial class ModificaCarte : Form
    {
        public HomeForm homeForm;
        public ModificaCarte()
        {
            InitializeComponent();
            foreach(Carte c in HomeForm.listaCarti)
            {
                comboBox1.Items.Add(c.Nume);
            }
            disableFields();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < HomeForm.listaCarti.Count; i++)
            {
                if (HomeForm.listaCarti[i].Nume == comboBox1.SelectedItem)
                {
                    int k = i;
                    if (comboBox1.SelectedIndex != -1) enableFields();

                    int n = 0;
                    if (radioButtonChildren.Checked == true) n = 1;
                    if (radioButtonFiction.Checked == true) n = 2;
                    if (radioButtonBiografy.Checked == true) n = 3;
                    if (radioButtonSpeciality.Checked == true) n = 4;

                    bool autor, editor, an, nrexem, radio = false;



                    if (textBoxAuthor.Text == "" || textBoxAuthor.Text.Length < 3)
                    {
                        errorProvider1.SetError(this.textBoxAuthor, "Introduceți autorul carții");
                        labelMessageStatus.Text = "";
                        autor = false;
                    }
                    else { errorProvider1.Clear(); autor = true; }

                    if (textBoxEdithor.Text == "" || textBoxEdithor.Text.Length < 3)
                    {
                        errorProvider1.SetError(this.textBoxEdithor, "Introduceți editura carții");
                        labelMessageStatus.Text = "";
                        editor = false;
                    }
                    else { errorProvider1.Clear(); editor = true; }

                    if (textBoxYear.Text == "" || (Int32.Parse(textBoxYear.Text) > 2022 && Int32.Parse(textBoxYear.Text) < 1899))
                    {
                        errorProvider1.SetError(this.textBoxYear, "Introduceți anul publicării");
                        labelMessageStatus.Text = "";
                        an = false;
                    }
                    else { errorProvider1.Clear(); an = true; }

                    if (textBoxNumberExemplar.Text == "" || Int32.Parse(textBoxNumberExemplar.Text) < 0)
                    {
                        errorProvider1.SetError(this.textBoxNumberExemplar, "Introduceți numărul de exemplare");
                        labelMessageStatus.Text = "";
                        nrexem = false;
                    }
                    else { errorProvider1.Clear(); nrexem = true; }

                    if (radioButtonChildren.Checked == false && radioButtonBiografy.Checked == false && radioButtonFiction.Checked == false && radioButtonSpeciality.Checked == false)
                    {
                        errorProvider1.SetError(this.label6, "Selectați genul carții");
                        labelMessageStatus.Text = "";
                        radio = false;
                    }
                    else { errorProvider1.Clear(); radio = true; }

                    if (autor == true && editor == true && an == true && nrexem == true && radio == true)
                    {
                        labelMessageStatus.Visible = true;
                        labelMessageStatus.Text = "Carte actualizata cu succes!";
                        labelMessageStatus.ForeColor = Color.White;

                        HomeForm.listaCarti[i].Autor = textBoxAuthor.Text;
                        HomeForm.listaCarti[i].Editura = textBoxEdithor.Text;
                        HomeForm.listaCarti[i].AnAparitie = Convert.ToInt32(textBoxYear.Text);
                        HomeForm.listaCarti[i].NrExemplare = Convert.ToInt32(textBoxNumberExemplar.Text);
                        HomeForm.listaCarti[i].GenCarte = (GENCARTE)n;
                        HomeForm.listaCarti[i].DataActualizare = DateTime.Now;

                        resetFileds();
                    }

                }
            }
        }

        private void enableFields()
        {
            textBoxAuthor.Enabled = true;
            textBoxEdithor.Enabled = true;
            textBoxNumberExemplar.Enabled = true;
            textBoxYear.Enabled = true;
            radioButtonBiografy.Enabled = true;
            radioButtonChildren.Enabled = true;
            radioButtonSpeciality.Enabled = true;
            radioButtonFiction.Enabled = true;
        }
        private void disableFields()
        {
            textBoxAuthor.Enabled = false;
            textBoxEdithor.Enabled = false;
            textBoxNumberExemplar.Enabled = false;
            textBoxYear.Enabled = false;
            radioButtonBiografy.Enabled = false;
            radioButtonChildren.Enabled = false;
            radioButtonSpeciality.Enabled = false;
            radioButtonFiction.Enabled = false;
        }


        private void resetFileds()
        {
            comboBox1.ResetText();
            textBoxAuthor.Text = "";
            textBoxEdithor.Text = "";
            textBoxNumberExemplar.Text = "";
            textBoxYear.Text = "";
            radioButtonBiografy.Checked = false;
            radioButtonChildren.Checked = false;
            radioButtonSpeciality.Checked = false;
            radioButtonFiction.Checked = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }
    }
}
