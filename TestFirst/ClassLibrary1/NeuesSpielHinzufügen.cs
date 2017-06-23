using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace SteamBibliothek
{
    public partial class NeuesSpielHinzufügenForm : Form
    {
        public NeuesSpielHinzufügenForm()
        {
            InitializeComponent();
        }

        private void USKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void SpielSpeichernButton_Click(object sender, EventArgs e)
        {
            Spiel spiel = new Spiel();
            spiel.zuletzt_gespielt = null;
            spiel.InstallationsDatum = DateTime.Now;
            spiel.USK = Convert.ToInt32(USKTextBox.Text);
            //spiel.
            spiel.Publisher = Convert.ToString(FileVersionInfo.GetVersionInfo(DateipfadTextBox.Text).CompanyName);
            spiel.Titel= Convert.ToString(Assembly.LoadFile(DateipfadTextBox.Text).GetName());
            spiel.Kategorie = KategorieTextBox.Text;
            Form neuesspielhinzufügenform = new NeuesSpielHinzufügenForm();
            neuesspielhinzufügenform.Close();
        }

    }
}
