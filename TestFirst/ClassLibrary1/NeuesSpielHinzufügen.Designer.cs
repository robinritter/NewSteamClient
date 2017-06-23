namespace SteamBibliothek
{
    partial class NeuesSpielHinzufügenForm
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
            this.DateipfadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpielSpeichernButton = new System.Windows.Forms.Button();
            this.USKTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KategorieTextBox = new System.Windows.Forms.TextBox();
            this.KategorieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateipfadTextBox
            // 
            this.DateipfadTextBox.Location = new System.Drawing.Point(12, 40);
            this.DateipfadTextBox.Name = "DateipfadTextBox";
            this.DateipfadTextBox.Size = new System.Drawing.Size(428, 20);
            this.DateipfadTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dateipfad der .exe";
            // 
            // SpielSpeichernButton
            // 
            this.SpielSpeichernButton.Location = new System.Drawing.Point(281, 243);
            this.SpielSpeichernButton.Name = "SpielSpeichernButton";
            this.SpielSpeichernButton.Size = new System.Drawing.Size(159, 34);
            this.SpielSpeichernButton.TabIndex = 2;
            this.SpielSpeichernButton.Text = "Spiel Hinzufügen";
            this.SpielSpeichernButton.UseVisualStyleBackColor = true;
            this.SpielSpeichernButton.Click += new System.EventHandler(this.SpielSpeichernButton_Click);
            // 
            // USKTextBox
            // 
            this.USKTextBox.Location = new System.Drawing.Point(12, 219);
            this.USKTextBox.Name = "USKTextBox";
            this.USKTextBox.Size = new System.Drawing.Size(79, 20);
            this.USKTextBox.TabIndex = 3;
            this.USKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.USKTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "USK Einstufung";
            // 
            // KategorieTextBox
            // 
            this.KategorieTextBox.Location = new System.Drawing.Point(12, 89);
            this.KategorieTextBox.Name = "KategorieTextBox";
            this.KategorieTextBox.Size = new System.Drawing.Size(100, 20);
            this.KategorieTextBox.TabIndex = 5;
            // 
            // KategorieLabel
            // 
            this.KategorieLabel.AutoSize = true;
            this.KategorieLabel.Location = new System.Drawing.Point(12, 73);
            this.KategorieLabel.Name = "KategorieLabel";
            this.KategorieLabel.Size = new System.Drawing.Size(52, 13);
            this.KategorieLabel.TabIndex = 6;
            this.KategorieLabel.Text = "Kategorie";
            // 
            // NeuesSpielHinzufügenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(452, 289);
            this.Controls.Add(this.KategorieLabel);
            this.Controls.Add(this.KategorieTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.USKTextBox);
            this.Controls.Add(this.SpielSpeichernButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateipfadTextBox);
            this.Name = "NeuesSpielHinzufügenForm";
            this.Text = "NeuesSpielHinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DateipfadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SpielSpeichernButton;
        private System.Windows.Forms.TextBox USKTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KategorieTextBox;
        private System.Windows.Forms.Label KategorieLabel;
    }
}