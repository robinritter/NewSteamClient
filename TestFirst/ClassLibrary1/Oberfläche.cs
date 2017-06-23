using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace SteamBibliothek
{
    public partial class Oberfläche : Form
    {
        public Oberfläche()
        {
            List<Spiel> spieliste = new List<Spiel>();
            InitializeComponent();
            Controller controller = new Controller();
            controller.Datenladen();
            Button button = new Button();

            int x = 50;
            int y = 50;
            foreach(Spiel spiel in spieliste)
            {
                button.Name = spiel.Titel;
                button.Location = new Point(x, y);
                button.Visible = true;
                button.AutoSize = true;
                button.MouseDown += (sender, args) =>
                    {
                        MessageBox.Show(spiel.Titel + "/n" + Convert.ToString(spiel.InstallationsDatum) + "/n" + spiel.Publisher + "/n" + spiel.Kategorie + "/n" + Convert.ToString(spiel.USK) + "/n" + Convert.ToString(spiel.zuletzt_gespielt));
                    };
                button.DoubleClick += (sender, args) =>
                    {
                        controller.SpielStarten(spiel.Titel);
                    };
                x = x + 50;
                y = y + 50;
                //button.BackgroundImage = hier kommt dann das Bild rein der exe
            }
            

        }

        private void SpielHinzufügenButton_Click(object sender, EventArgs e)
        {
            Form spielhinzufügenform = new NeuesSpielHinzufügenForm();
            spielhinzufügenform.Show(this);
        }

    }
}
