using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace SteamBibliothek
{
    public class Controller
    {
        public void Spielhinzufügen(string Titel, string ErstellDatum, string Zuletztgespielt, string Kategorie, string Publisher, int USK)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("SpielListe.xml");
            XmlNode newGameNode = xdoc.CreateElement("Spiel");
            XmlNode TitelNode = xdoc.CreateElement("Titel");
            XmlNode ErstelldatumNode = xdoc.CreateElement("ErstellDatum");
            XmlNode ZuletztgespieltNode = xdoc.CreateElement("Zuletzt_gespielt");
            XmlNode KategorieNode = xdoc.CreateElement("Kategorie");
            XmlNode PublisherNode = xdoc.CreateElement("Publisher");
            XmlNode USKNode = xdoc.CreateElement("USK");
        } 

        public void Spielentfernen(string Titel)
        {
            throw new NotImplementedException();
        }

        public void Spielstarten(string Titel)
        {
            throw new NotImplementedException();
        }

        public void Datenladen()
        {
            throw new NotImplementedException();
        }

        public void Datenschreiben()
        {
            throw new NotImplementedException();
        }
    }
}
