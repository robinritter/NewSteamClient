namespace SteamBibliothek
{
    partial class Oberfläche
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SpielHinzufügenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(812, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 458);
            this.vScrollBar1.TabIndex = 0;
            // 
            // SpielHinzufügenButton
            // 
            this.SpielHinzufügenButton.Location = new System.Drawing.Point(12, 9);
            this.SpielHinzufügenButton.Name = "SpielHinzufügenButton";
            this.SpielHinzufügenButton.Size = new System.Drawing.Size(35, 32);
            this.SpielHinzufügenButton.TabIndex = 1;
            this.SpielHinzufügenButton.Text = "+";
            this.SpielHinzufügenButton.UseVisualStyleBackColor = true;
            this.SpielHinzufügenButton.Click += new System.EventHandler(this.SpielHinzufügenButton_Click);
            // 
            // Oberfläche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(838, 476);
            this.Controls.Add(this.SpielHinzufügenButton);
            this.Controls.Add(this.vScrollBar1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Oberfläche";
            this.Text = "Oberfläche";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button SpielHinzufügenButton;
    }
}