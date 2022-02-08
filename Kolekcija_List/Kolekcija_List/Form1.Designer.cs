namespace Kolekcija_List
{
    partial class Form1
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
            this.button_Unos = new System.Windows.Forms.Button();
            this.textBox_Ime = new System.Windows.Forms.TextBox();
            this.textBox_Prezime = new System.Windows.Forms.TextBox();
            this.label_Ime = new System.Windows.Forms.Label();
            this.label_Prezime = new System.Windows.Forms.Label();
            this.label_Razred = new System.Windows.Forms.Label();
            this.comboBox_Razred = new System.Windows.Forms.ComboBox();
            this.button_Pregled = new System.Windows.Forms.Button();
            this.button_Obrada = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_Unos
            // 
            this.button_Unos.Location = new System.Drawing.Point(22, 176);
            this.button_Unos.Name = "button_Unos";
            this.button_Unos.Size = new System.Drawing.Size(164, 65);
            this.button_Unos.TabIndex = 0;
            this.button_Unos.Text = "Unos";
            this.button_Unos.UseVisualStyleBackColor = true;
            this.button_Unos.Click += new System.EventHandler(this.button_Unos_Click);
            // 
            // textBox_Ime
            // 
            this.textBox_Ime.Location = new System.Drawing.Point(22, 30);
            this.textBox_Ime.Multiline = true;
            this.textBox_Ime.Name = "textBox_Ime";
            this.textBox_Ime.Size = new System.Drawing.Size(164, 20);
            this.textBox_Ime.TabIndex = 1;
            // 
            // textBox_Prezime
            // 
            this.textBox_Prezime.Location = new System.Drawing.Point(22, 78);
            this.textBox_Prezime.Multiline = true;
            this.textBox_Prezime.Name = "textBox_Prezime";
            this.textBox_Prezime.Size = new System.Drawing.Size(164, 20);
            this.textBox_Prezime.TabIndex = 2;
            // 
            // label_Ime
            // 
            this.label_Ime.AutoSize = true;
            this.label_Ime.Location = new System.Drawing.Point(19, 14);
            this.label_Ime.Name = "label_Ime";
            this.label_Ime.Size = new System.Drawing.Size(24, 13);
            this.label_Ime.TabIndex = 3;
            this.label_Ime.Text = "Ime";
            // 
            // label_Prezime
            // 
            this.label_Prezime.AutoSize = true;
            this.label_Prezime.Location = new System.Drawing.Point(22, 57);
            this.label_Prezime.Name = "label_Prezime";
            this.label_Prezime.Size = new System.Drawing.Size(44, 13);
            this.label_Prezime.TabIndex = 4;
            this.label_Prezime.Text = "Prezime";
            // 
            // label_Razred
            // 
            this.label_Razred.AutoSize = true;
            this.label_Razred.Location = new System.Drawing.Point(19, 111);
            this.label_Razred.Name = "label_Razred";
            this.label_Razred.Size = new System.Drawing.Size(41, 13);
            this.label_Razred.TabIndex = 5;
            this.label_Razred.Text = "Razred";
            // 
            // comboBox_Razred
            // 
            this.comboBox_Razred.FormattingEnabled = true;
            this.comboBox_Razred.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4."});
            this.comboBox_Razred.Location = new System.Drawing.Point(22, 129);
            this.comboBox_Razred.Name = "comboBox_Razred";
            this.comboBox_Razred.Size = new System.Drawing.Size(164, 21);
            this.comboBox_Razred.TabIndex = 6;
            // 
            // button_Pregled
            // 
            this.button_Pregled.Location = new System.Drawing.Point(211, 176);
            this.button_Pregled.Name = "button_Pregled";
            this.button_Pregled.Size = new System.Drawing.Size(164, 65);
            this.button_Pregled.TabIndex = 7;
            this.button_Pregled.Text = "Pregled";
            this.button_Pregled.UseVisualStyleBackColor = true;
            this.button_Pregled.Click += new System.EventHandler(this.button_Pregled_Click);
            // 
            // button_Obrada
            // 
            this.button_Obrada.Location = new System.Drawing.Point(404, 176);
            this.button_Obrada.Name = "button_Obrada";
            this.button_Obrada.Size = new System.Drawing.Size(164, 65);
            this.button_Obrada.TabIndex = 8;
            this.button_Obrada.Text = "Obrada";
            this.button_Obrada.UseVisualStyleBackColor = true;
            this.button_Obrada.Click += new System.EventHandler(this.button_Obrada_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(546, 149);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 408);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_Obrada);
            this.Controls.Add(this.button_Pregled);
            this.Controls.Add(this.comboBox_Razred);
            this.Controls.Add(this.label_Razred);
            this.Controls.Add(this.label_Prezime);
            this.Controls.Add(this.label_Ime);
            this.Controls.Add(this.textBox_Prezime);
            this.Controls.Add(this.textBox_Ime);
            this.Controls.Add(this.button_Unos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Unos;
        private System.Windows.Forms.TextBox textBox_Ime;
        private System.Windows.Forms.TextBox textBox_Prezime;
        private System.Windows.Forms.Label label_Ime;
        private System.Windows.Forms.Label label_Prezime;
        private System.Windows.Forms.Label label_Razred;
        private System.Windows.Forms.ComboBox comboBox_Razred;
        private System.Windows.Forms.Button button_Pregled;
        private System.Windows.Forms.Button button_Obrada;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

