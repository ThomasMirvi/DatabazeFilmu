namespace DatabazeFilmu
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmYear = new System.Windows.Forms.TextBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownRating)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilmName
            // 
            this.txtFilmName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFilmName.Location = new System.Drawing.Point(178, 221);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(189, 32);
            this.txtFilmName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(81, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Název:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(81, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(81, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Žánr:";
            // 
            // txtFilmYear
            // 
            this.txtFilmYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFilmYear.Location = new System.Drawing.Point(178, 262);
            this.txtFilmYear.Name = "txtFilmYear";
            this.txtFilmYear.Size = new System.Drawing.Size(189, 32);
            this.txtFilmYear.TabIndex = 8;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Akční  ",
            "Dobrodružný  ",
            "Animovaný  ",
            "Komedie  ",
            "Drama  ",
            "Horor  ",
            "Mysteriózní  ",
            "Thriller  ",
            "Sci-Fi  ",
            "Fantasy  ",
            "Historický  ",
            "Romantický  ",
            "Muzikál  ",
            "Dokumentární  ",
            "Krimi  ",
            "Western  ",
            "Válečný  ",
            "Sportovní  ",
            "Rodinný  ",
            "Fantasy  ",
            "Kultovní",
            "Jiné"});
            this.comboBoxGenre.Location = new System.Drawing.Point(178, 300);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(190, 32);
            this.comboBoxGenre.TabIndex = 9;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.BackColor = System.Drawing.Color.Firebrick;
            this.btnAddFilm.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddFilm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddFilm.Location = new System.Drawing.Point(135, 458);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(172, 58);
            this.btnAddFilm.TabIndex = 10;
            this.btnAddFilm.Text = "Přidat";
            this.btnAddFilm.UseVisualStyleBackColor = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDirector.Location = new System.Drawing.Point(178, 338);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(190, 32);
            this.txtDirector.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(81, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Režie:";
            // 
            // nmUpDownRating
            // 
            this.nmUpDownRating.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmUpDownRating.Location = new System.Drawing.Point(247, 381);
            this.nmUpDownRating.Name = "nmUpDownRating";
            this.nmUpDownRating.Size = new System.Drawing.Size(121, 32);
            this.nmUpDownRating.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 73);
            this.panel2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(132, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 49);
            this.label5.TabIndex = 1;
            this.label5.Text = "Přidat film";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 73);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(178, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 49);
            this.label6.TabIndex = 2;
            this.label6.Text = "ČSFD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(81, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hodnocení:";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(450, 563);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nmUpDownRating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.txtFilmYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.Text = "ČSFD - Přidat film";
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownRating)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilmYear;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmUpDownRating;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}