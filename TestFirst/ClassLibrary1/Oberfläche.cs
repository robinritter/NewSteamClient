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
            int x = 0;
            int y = 0;
            foreach(Spiel spiel in spieliste)
            {
                button.Name = spiel.Titel;
                button.Location= 

            }
            

        }

        private void SpielHinzufügenButton_Click(object sender, EventArgs e)
        {
            Form spielhinzufügenform = new NeuesSpielHinzufügenForm();
            spielhinzufügenform.Show(this);
        }

    }
}
