using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamBibliothek;
namespace TestFirst
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        public void TestMethodSpielhinzufügen()
        {
            Controller controller = new Controller();
            controller.Spiellisteerstellen();
            string Titel = "Master of Moodle";
            string Datum = "01.01.1999";
            string Zuletztgespielt = "14.06.2017";
            string Kategorie = "Action";
            string Publisher = "me";
            int USK = 21;
            controller.Spielhinzufügen(Titel, Datum, Zuletztgespielt, Kategorie, Publisher, USK);
            
        }
        [TestMethod]
        public void TestMethodSpielentfernen()
        {
            Controller controller = new Controller();
            string Titel = "Master of Moodle";
            controller.Spielentfernen(Titel);
        }
        [TestMethod]
        public void TestMethodProgrammstarten()
        {
            Controller controller = new Controller();
            string Titel = "Master of Moodle";
            controller.SpielStarten(Titel);
        }
        [TestMethod]
        public void TestMethodDatenladen()
        {
            Controller controller = new Controller();
            controller.Datenladen();
        }
    }
}
