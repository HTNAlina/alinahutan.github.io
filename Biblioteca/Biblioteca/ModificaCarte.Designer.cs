
namespace Biblioteca
{
    partial class ModificaCarte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaCarte));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxEdithor = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxNumberExemplar = new System.Windows.Forms.TextBox();
            this.radioButtonChildren = new System.Windows.Forms.RadioButton();
            this.radioButtonFiction = new System.Windows.Forms.RadioButton();
            this.radioButtonBiografy = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeciality = new System.Windows.Forms.RadioButton();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMessageStatus = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Enabled = false;
            this.textBoxAuthor.Location = new System.Drawing.Point(467, 149);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(217, 26);
            this.textBoxAuthor.TabIndex = 1;
            // 
            // textBoxEdithor
            // 
            this.textBoxEdithor.Enabled = false;
            this.textBoxEdithor.Location = new System.Drawing.Point(467, 230);
            this.textBoxEdithor.Name = "textBoxEdithor";
            this.textBoxEdithor.Size = new System.Drawing.Size(217, 26);
            this.textBoxEdithor.TabIndex = 2;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Enabled = false;
            this.textBoxYear.Location = new System.Drawing.Point(467, 318);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(217, 26);
            this.textBoxYear.TabIndex = 3;
            // 
            // textBoxNumberExemplar
            // 
            this.textBoxNumberExemplar.Enabled = false;
            this.textBoxNumberExemplar.Location = new System.Drawing.Point(467, 397);
            this.textBoxNumberExemplar.Name = "textBoxNumberExemplar";
            this.textBoxNumberExemplar.Size = new System.Drawing.Size(217, 26);
            this.textBoxNumberExemplar.TabIndex = 4;
            // 
            // radioButtonChildren
            // 
            this.radioButtonChildren.AutoSize = true;
            this.radioButtonChildren.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonChildren.Enabled = false;
            this.radioButtonChildren.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChildren.ForeColor = System.Drawing.Color.White;
            this.radioButtonChildren.Location = new System.Drawing.Point(467, 461);
            this.radioButtonChildren.Name = "radioButtonChildren";
            this.radioButtonChildren.Size = new System.Drawing.Size(81, 26);
            this.radioButtonChildren.TabIndex = 5;
            this.radioButtonChildren.TabStop = true;
            this.radioButtonChildren.Text = "Copii";
            this.radioButtonChildren.UseVisualStyleBackColor = false;
            // 
            // radioButtonFiction
            // 
            this.radioButtonFiction.AutoSize = true;
            this.radioButtonFiction.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFiction.Enabled = false;
            this.radioButtonFiction.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFiction.ForeColor = System.Drawing.Color.White;
            this.radioButtonFiction.Location = new System.Drawing.Point(613, 461);
            this.radioButtonFiction.Name = "radioButtonFiction";
            this.radioButtonFiction.Size = new System.Drawing.Size(105, 26);
            this.radioButtonFiction.TabIndex = 6;
            this.radioButtonFiction.TabStop = true;
            this.radioButtonFiction.Text = "Fictiune";
            this.radioButtonFiction.UseVisualStyleBackColor = false;
            this.radioButtonFiction.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonBiografy
            // 
            this.radioButtonBiografy.AutoSize = true;
            this.radioButtonBiografy.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonBiografy.Enabled = false;
            this.radioButtonBiografy.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBiografy.ForeColor = System.Drawing.Color.White;
            this.radioButtonBiografy.Location = new System.Drawing.Point(467, 518);
            this.radioButtonBiografy.Name = "radioButtonBiografy";
            this.radioButtonBiografy.Size = new System.Drawing.Size(118, 26);
            this.radioButtonBiografy.TabIndex = 7;
            this.radioButtonBiografy.TabStop = true;
            this.radioButtonBiografy.Text = "Biografie";
            this.radioButtonBiografy.UseVisualStyleBackColor = false;
            // 
            // radioButtonSpeciality
            // 
            this.radioButtonSpeciality.AutoSize = true;
            this.radioButtonSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSpeciality.Enabled = false;
            this.radioButtonSpeciality.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSpeciality.ForeColor = System.Drawing.Color.White;
            this.radioButtonSpeciality.Location = new System.Drawing.Point(613, 518);
            this.radioButtonSpeciality.Name = "radioButtonSpeciality";
            this.radioButtonSpeciality.Size = new System.Drawing.Size(138, 26);
            this.radioButtonSpeciality.TabIndex = 8;
            this.radioButtonSpeciality.TabStop = true;
            this.radioButtonSpeciality.Text = "Specialitate";
            this.radioButtonSpeciality.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(1063, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(48, 48);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOk.BackgroundImage")));
            this.buttonOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Location = new System.Drawing.Point(553, 579);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(48, 48);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Titlu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Editor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Anul publicarii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Numar exemplare";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(549, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gen";
            // 
            // labelMessageStatus
            // 
            this.labelMessageStatus.AutoSize = true;
            this.labelMessageStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelMessageStatus.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageStatus.ForeColor = System.Drawing.Color.White;
            this.labelMessageStatus.Location = new System.Drawing.Point(643, 587);
            this.labelMessageStatus.Name = "labelMessageStatus";
            this.labelMessageStatus.Size = new System.Drawing.Size(221, 27);
            this.labelMessageStatus.TabIndex = 20;
            this.labelMessageStatus.Text = "labelMessageStatus";
            this.labelMessageStatus.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModificaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 662);
            this.Controls.Add(this.labelMessageStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.radioButtonSpeciality);
            this.Controls.Add(this.radioButtonBiografy);
            this.Controls.Add(this.radioButtonFiction);
            this.Controls.Add(this.radioButtonChildren);
            this.Controls.Add(this.textBoxNumberExemplar);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxEdithor);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificaCarte";
            this.Text = "ModificaCarte";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxEdithor;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxNumberExemplar;
        private System.Windows.Forms.RadioButton radioButtonChildren;
        private System.Windows.Forms.RadioButton radioButtonFiction;
        private System.Windows.Forms.RadioButton radioButtonBiografy;
        private System.Windows.Forms.RadioButton radioButtonSpeciality;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMessageStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}