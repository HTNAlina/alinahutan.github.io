
namespace Biblioteca
{
    partial class FormAddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBook));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxNumberExemplar = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonChildren = new System.Windows.Forms.RadioButton();
            this.radioButtonFiction = new System.Windows.Forms.RadioButton();
            this.radioButtonBiografy = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeciality = new System.Windows.Forms.RadioButton();
            this.labelMessageStatus = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(451, 49);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(239, 26);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(451, 123);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(239, 26);
            this.textBoxAuthor.TabIndex = 1;
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.Location = new System.Drawing.Point(451, 182);
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.Size = new System.Drawing.Size(239, 26);
            this.textBoxEditor.TabIndex = 2;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(451, 242);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(239, 26);
            this.textBoxYear.TabIndex = 3;
            // 
            // textBoxNumberExemplar
            // 
            this.textBoxNumberExemplar.Location = new System.Drawing.Point(451, 453);
            this.textBoxNumberExemplar.Name = "textBoxNumberExemplar";
            this.textBoxNumberExemplar.Size = new System.Drawing.Size(239, 26);
            this.textBoxNumberExemplar.TabIndex = 5;
            this.textBoxNumberExemplar.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddBook.BackgroundImage")));
            this.buttonAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddBook.FlatAppearance.BorderSize = 0;
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.Location = new System.Drawing.Point(538, 518);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(37, 30);
            this.buttonAddBook.TabIndex = 7;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(1058, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(34, 34);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(526, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Titlu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(526, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Autor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(521, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Editura";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(481, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Anul publicării";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(463, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Număr exemplare";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(507, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gen Carte";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonChildren
            // 
            this.radioButtonChildren.AutoSize = true;
            this.radioButtonChildren.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonChildren.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChildren.Location = new System.Drawing.Point(451, 326);
            this.radioButtonChildren.Name = "radioButtonChildren";
            this.radioButtonChildren.Size = new System.Drawing.Size(81, 26);
            this.radioButtonChildren.TabIndex = 15;
            this.radioButtonChildren.TabStop = true;
            this.radioButtonChildren.Text = "Copii";
            this.radioButtonChildren.UseVisualStyleBackColor = false;
            // 
            // radioButtonFiction
            // 
            this.radioButtonFiction.AutoSize = true;
            this.radioButtonFiction.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFiction.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFiction.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.radioButtonFiction.Location = new System.Drawing.Point(600, 326);
            this.radioButtonFiction.Name = "radioButtonFiction";
            this.radioButtonFiction.Size = new System.Drawing.Size(104, 26);
            this.radioButtonFiction.TabIndex = 16;
            this.radioButtonFiction.TabStop = true;
            this.radioButtonFiction.Text = "Ficțiune";
            this.radioButtonFiction.UseVisualStyleBackColor = false;
            // 
            // radioButtonBiografy
            // 
            this.radioButtonBiografy.AutoSize = true;
            this.radioButtonBiografy.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonBiografy.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBiografy.Location = new System.Drawing.Point(451, 379);
            this.radioButtonBiografy.Name = "radioButtonBiografy";
            this.radioButtonBiografy.Size = new System.Drawing.Size(114, 26);
            this.radioButtonBiografy.TabIndex = 17;
            this.radioButtonBiografy.TabStop = true;
            this.radioButtonBiografy.Text = "Biografii";
            this.radioButtonBiografy.UseVisualStyleBackColor = false;
            this.radioButtonBiografy.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonSpeciality
            // 
            this.radioButtonSpeciality.AutoSize = true;
            this.radioButtonSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSpeciality.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSpeciality.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonSpeciality.Location = new System.Drawing.Point(600, 379);
            this.radioButtonSpeciality.Name = "radioButtonSpeciality";
            this.radioButtonSpeciality.Size = new System.Drawing.Size(138, 26);
            this.radioButtonSpeciality.TabIndex = 18;
            this.radioButtonSpeciality.TabStop = true;
            this.radioButtonSpeciality.Text = "Specialitate";
            this.radioButtonSpeciality.UseVisualStyleBackColor = false;
            // 
            // labelMessageStatus
            // 
            this.labelMessageStatus.AutoSize = true;
            this.labelMessageStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelMessageStatus.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageStatus.ForeColor = System.Drawing.Color.White;
            this.labelMessageStatus.Location = new System.Drawing.Point(457, 580);
            this.labelMessageStatus.Name = "labelMessageStatus";
            this.labelMessageStatus.Size = new System.Drawing.Size(221, 27);
            this.labelMessageStatus.TabIndex = 19;
            this.labelMessageStatus.Text = "labelMessageStatus";
            this.labelMessageStatus.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 664);
            this.Controls.Add(this.labelMessageStatus);
            this.Controls.Add(this.radioButtonSpeciality);
            this.Controls.Add(this.radioButtonBiografy);
            this.Controls.Add(this.radioButtonFiction);
            this.Controls.Add(this.radioButtonChildren);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBoxNumberExemplar);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxEditor);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddBook";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxEditor;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxNumberExemplar;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonChildren;
        private System.Windows.Forms.RadioButton radioButtonFiction;
        private System.Windows.Forms.RadioButton radioButtonBiografy;
        private System.Windows.Forms.RadioButton radioButtonSpeciality;
        private System.Windows.Forms.Label labelMessageStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}