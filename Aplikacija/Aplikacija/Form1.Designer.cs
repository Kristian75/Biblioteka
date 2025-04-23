namespace Aplikacija
{
    partial class Novi_korisnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClanskiID = new System.Windows.Forms.TextBox();
            this.btnNovaKnjiga = new System.Windows.Forms.Button();
            this.btnPosudba = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnKnjige = new System.Windows.Forms.Button();
            this.btnPosudbe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(140, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(128, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(95, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clanski ID:";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(186, 91);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(261, 26);
            this.txtIme.TabIndex = 3;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKorisnika.Location = new System.Drawing.Point(232, 263);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(125, 28);
            this.btnDodajKorisnika.TabIndex = 6;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.Location = new System.Drawing.Point(186, 148);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtClanskiID
            // 
            this.txtClanskiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtClanskiID.Location = new System.Drawing.Point(186, 203);
            this.txtClanskiID.Multiline = true;
            this.txtClanskiID.Name = "txtClanskiID";
            this.txtClanskiID.Size = new System.Drawing.Size(261, 26);
            this.txtClanskiID.TabIndex = 8;
            // 
            // btnNovaKnjiga
            // 
            this.btnNovaKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaKnjiga.Location = new System.Drawing.Point(541, 114);
            this.btnNovaKnjiga.Name = "btnNovaKnjiga";
            this.btnNovaKnjiga.Size = new System.Drawing.Size(172, 28);
            this.btnNovaKnjiga.TabIndex = 9;
            this.btnNovaKnjiga.Text = "Nova knjiga";
            this.btnNovaKnjiga.UseVisualStyleBackColor = true;
            this.btnNovaKnjiga.Click += new System.EventHandler(this.btnNovaKnjiga_Click);
            // 
            // btnPosudba
            // 
            this.btnPosudba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosudba.Location = new System.Drawing.Point(541, 148);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(172, 28);
            this.btnPosudba.TabIndex = 10;
            this.btnPosudba.Text = "Posudi ili vrati knjigu";
            this.btnPosudba.UseVisualStyleBackColor = true;
            this.btnPosudba.Click += new System.EventHandler(this.btnPosudba_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKorisnici.Location = new System.Drawing.Point(541, 229);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(172, 28);
            this.btnKorisnici.TabIndex = 11;
            this.btnKorisnici.Text = "Postojeći korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnKnjige
            // 
            this.btnKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKnjige.Location = new System.Drawing.Point(541, 263);
            this.btnKnjige.Name = "btnKnjige";
            this.btnKnjige.Size = new System.Drawing.Size(172, 28);
            this.btnKnjige.TabIndex = 12;
            this.btnKnjige.Text = "Postojeće knjige";
            this.btnKnjige.UseVisualStyleBackColor = true;
            this.btnKnjige.Click += new System.EventHandler(this.btnKnjige_Click);
            // 
            // btnPosudbe
            // 
            this.btnPosudbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosudbe.Location = new System.Drawing.Point(541, 317);
            this.btnPosudbe.Name = "btnPosudbe";
            this.btnPosudbe.Size = new System.Drawing.Size(172, 28);
            this.btnPosudbe.TabIndex = 13;
            this.btnPosudbe.Text = "Lista posudba";
            this.btnPosudbe.UseVisualStyleBackColor = true;
            this.btnPosudbe.Click += new System.EventHandler(this.btnPosudbe_Click);
            // 
            // Novi_korisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPosudbe);
            this.Controls.Add(this.btnKnjige);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnPosudba);
            this.Controls.Add(this.btnNovaKnjiga);
            this.Controls.Add(this.txtClanskiID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Novi_korisnik";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClanskiID;
        private System.Windows.Forms.Button btnNovaKnjiga;
        private System.Windows.Forms.Button btnPosudba;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnKnjige;
        private System.Windows.Forms.Button btnPosudbe;
    }
}

