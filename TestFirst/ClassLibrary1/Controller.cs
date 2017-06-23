using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Diagnostics;



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
            xdoc.Save("SpielListe.xml");
        } 
        public void Spiellisteerstellen()
        {
            string filename = "Spielliste.xml";
            XmlDocument xdoc = new XmlDocument();
            if(File.Exists(filename)== false)
            {
                XmlDeclaration declaration = xdoc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
                xdoc.InsertBefore(declaration, xdoc.DocumentElement);
                XmlNode rootNode = xdoc.CreateElement("SpielListe.xml");
                xdoc.AppendChild(rootNode);
                xdoc.Save("SpielListe.xml");
            }
        }

        public void Spielentfernen(string Titel)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("SpielListe.xml");
            XmlNode xnodelist = xdoc.SelectSingleNode("//SpielListe/Spiel/" + Titel);
            xdoc.RemoveChild(xnodelist);
            xdoc.Save("SpielListe.xml");
        }

        public void SpielStarten(string Titel)
        {
            Process.Start(Titel + ".exe");
        }

        public void Datenladen()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("SpielListe.xml");
            XmlNodeList SpielNodeList = xdoc.SelectNodes("//SpielListe/Spiel");
            List<Spiel> spiel = new List<Spiel>();
            foreach(XmlNode SpielNode in SpielNodeList)
            {   
                XmlNode TitleNode = xdoc.SelectSingleNode("//SpielListe/Spiel/Titel");
                XmlNode ErstelldatumNode = xdoc.SelectSingleNode("//SpielListe/Spiel/ErstellDatum");
                XmlNode ZuletztGespieltNode = xdoc.SelectSingleNode("//SpielListe/Spiel/Zuletzt_gespielt");
                XmlNode PublisherNode = xdoc.SelectSingleNode("//SpielListe/Spiel/Publisher");
                XmlNode KategorieNode = xdoc.SelectSingleNode("//SpielListe/Spiel/Kategorie");
                XmlNode USKNode = xdoc.SelectSingleNode("//SpielListe/Spiel/USK");
                spiel.Add(new Spiel()
                {
                    Titel = TitleNode.InnerText,
                    InstallationsDatum = Convert.ToDateTime(ErstelldatumNode.InnerText),
                    zuletzt_gespielt = Convert.ToDateTime(ZuletztGespieltNode.InnerText),
                    Kategorie = KategorieNode.InnerText,
                    Publisher = PublisherNode.InnerText,
                    USK = Convert.ToInt32(USKNode.InnerText)
                });
            }

        }
    }
}
