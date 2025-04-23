namespace Aplikacija
{
    partial class Posudbe
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
            this.lstPosudbe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPosudbe
            // 
            this.lstPosudbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstPosudbe.FormattingEnabled = true;
            this.lstPosudbe.ItemHeight = 20;
            this.lstPosudbe.Location = new System.Drawing.Point(142, 115);
            this.lstPosudbe.Name = "lstPosudbe";
            this.lstPosudbe.Size = new System.Drawing.Size(467, 264);
            this.lstPosudbe.TabIndex = 0;
            this.lstPosudbe.SelectedIndexChanged += new System.EventHandler(this.lstPosudbe_SelectedIndexChanged);
            // 
            // Posudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPosudbe);
            this.Name = "Posudbe";
            this.Text = "Posudbe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPosudbe;
    }
}