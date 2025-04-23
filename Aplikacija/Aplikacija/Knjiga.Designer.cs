namespace Aplikacija
{
    partial class Knjiga
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
            this.txtPretragaKnjiga = new System.Windows.Forms.TextBox();
            this.lstKnjige = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPretragaKnjiga
            // 
            this.txtPretragaKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretragaKnjiga.Location = new System.Drawing.Point(187, 96);
            this.txtPretragaKnjiga.Multiline = true;
            this.txtPretragaKnjiga.Name = "txtPretragaKnjiga";
            this.txtPretragaKnjiga.Size = new System.Drawing.Size(330, 28);
            this.txtPretragaKnjiga.TabIndex = 0;
            this.txtPretragaKnjiga.TextChanged += new System.EventHandler(this.txtPretragaKnjiga_TextChanged);
            // 
            // lstKnjige
            // 
            this.lstKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstKnjige.FormattingEnabled = true;
            this.lstKnjige.ItemHeight = 20;
            this.lstKnjige.Location = new System.Drawing.Point(187, 165);
            this.lstKnjige.Name = "lstKnjige";
            this.lstKnjige.Size = new System.Drawing.Size(330, 124);
            this.lstKnjige.TabIndex = 1;
            // 
            // Knjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKnjige);
            this.Controls.Add(this.txtPretragaKnjiga);
            this.Name = "Knjiga";
            this.Text = "Knjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretragaKnjiga;
        private System.Windows.Forms.ListBox lstKnjige;
    }
}