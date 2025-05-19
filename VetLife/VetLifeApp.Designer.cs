namespace VetLife
{
    partial class VetLifeApp
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
            this.btnProprietar = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnConsultatie = new System.Windows.Forms.Button();
            this.btnConsultatiiV = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnIesire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGreutate = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtRasa = new System.Windows.Forms.TextBox();
            this.txtSpecie = new System.Windows.Forms.TextBox();
            this.txtNumeAnimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProprietar
            // 
            this.btnProprietar.Location = new System.Drawing.Point(600, 103);
            this.btnProprietar.Name = "btnProprietar";
            this.btnProprietar.Size = new System.Drawing.Size(158, 23);
            this.btnProprietar.TabIndex = 0;
            this.btnProprietar.Text = "Proprietar";
            this.btnProprietar.UseVisualStyleBackColor = true;
            this.btnProprietar.Click += new System.EventHandler(this.btnProprietar_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.Location = new System.Drawing.Point(600, 183);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(158, 23);
            this.btnAnimal.TabIndex = 1;
            this.btnAnimal.Text = "Adauga animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnConsultatie
            // 
            this.btnConsultatie.Location = new System.Drawing.Point(600, 259);
            this.btnConsultatie.Name = "btnConsultatie";
            this.btnConsultatie.Size = new System.Drawing.Size(158, 23);
            this.btnConsultatie.TabIndex = 2;
            this.btnConsultatie.Text = "Adauga consultatie";
            this.btnConsultatie.UseVisualStyleBackColor = true;
            this.btnConsultatie.Click += new System.EventHandler(this.btnConsultatie_Click);
            // 
            // btnConsultatiiV
            // 
            this.btnConsultatiiV.Location = new System.Drawing.Point(600, 288);
            this.btnConsultatiiV.Name = "btnConsultatiiV";
            this.btnConsultatiiV.Size = new System.Drawing.Size(158, 23);
            this.btnConsultatiiV.TabIndex = 3;
            this.btnConsultatiiV.Text = "Vizualizeaza consulatii";
            this.btnConsultatiiV.UseVisualStyleBackColor = true;
            this.btnConsultatiiV.Click += new System.EventHandler(this.btnConsultatiiV_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(600, 374);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(158, 23);
            this.btnPersonal.TabIndex = 4;
            this.btnPersonal.Text = "Gestioneaza personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Administrator",
            "Medic veterinar",
            "Asistent",
            "Operator"});
            this.listBox1.Location = new System.Drawing.Point(21, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(34, 259);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(75, 23);
            this.btnIesire.TabIndex = 6;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consultatii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Animale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proprietar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Optiuni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Administrator";
            // 
            // txtGreutate
            // 
            this.txtGreutate.Location = new System.Drawing.Point(337, 330);
            this.txtGreutate.Name = "txtGreutate";
            this.txtGreutate.Size = new System.Drawing.Size(100, 22);
            this.txtGreutate.TabIndex = 12;
            this.txtGreutate.TextChanged += new System.EventHandler(this.txtGreutate_TextChanged);
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(337, 260);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(100, 22);
            this.txtVarsta.TabIndex = 13;
            this.txtVarsta.TextChanged += new System.EventHandler(this.txtVarsta_TextChanged);
            // 
            // txtRasa
            // 
            this.txtRasa.Location = new System.Drawing.Point(337, 203);
            this.txtRasa.Name = "txtRasa";
            this.txtRasa.Size = new System.Drawing.Size(100, 22);
            this.txtRasa.TabIndex = 14;
            this.txtRasa.TextChanged += new System.EventHandler(this.txtRasa_TextChanged);
            // 
            // txtSpecie
            // 
            this.txtSpecie.Location = new System.Drawing.Point(337, 146);
            this.txtSpecie.Name = "txtSpecie";
            this.txtSpecie.Size = new System.Drawing.Size(100, 22);
            this.txtSpecie.TabIndex = 15;
            this.txtSpecie.TextChanged += new System.EventHandler(this.txtSpecie_TextChanged);
            // 
            // txtNumeAnimal
            // 
            this.txtNumeAnimal.Location = new System.Drawing.Point(337, 84);
            this.txtNumeAnimal.Name = "txtNumeAnimal";
            this.txtNumeAnimal.Size = new System.Drawing.Size(100, 22);
            this.txtNumeAnimal.TabIndex = 16;
            this.txtNumeAnimal.TextChanged += new System.EventHandler(this.txtNumeAnimal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nume";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Greutate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Varsta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Rasa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Specie";
            // 
            // VetLifeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeAnimal);
            this.Controls.Add(this.txtSpecie);
            this.Controls.Add(this.txtRasa);
            this.Controls.Add(this.txtVarsta);
            this.Controls.Add(this.txtGreutate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.btnConsultatiiV);
            this.Controls.Add(this.btnConsultatie);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.btnProprietar);
            this.Name = "VetLifeApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VetLifeApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProprietar;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnConsultatie;
        private System.Windows.Forms.Button btnConsultatiiV;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGreutate;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtRasa;
        private System.Windows.Forms.TextBox txtSpecie;
        private System.Windows.Forms.TextBox txtNumeAnimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

