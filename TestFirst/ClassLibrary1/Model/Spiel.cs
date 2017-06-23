using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamBibliothek.Model
{
    class Spiel
    {
        public string Titel
        {
            get;
            set;
        }
        public DateTime InstallationsDatum
        {
            get;
            set;
        }
        public DateTime? zuletzt_gespielt
        {
            get;
            set;
        }
        public string Kategorie
        {
            get;
            set;
        }
        public string Publisher
        {
            get;
            set;
        }
        public int USK
        {
            get;
            set;
        }
    }
}
