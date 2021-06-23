using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnervetwaltung
{
     class Rechner
    {
        //felder
        public string name;
        public string ip_Adresse;

        //Konstructur
        public Rechner (string name, string ip_Adresse)
        {
            this.name = name;
            this.ip_Adresse = ip_Adresse;
        }

        //Methode
        //public override string ToString()
        //{
        //    return "Name: " + name + "\nIp-Adresse: " + ip_Adresse;
        //}
        public override string ToString()
        {
            return $"\nName: {name}\nIP: {ip_Adresse}";
        }
    }

    class Beuro : Rechner
    {
        //felder
        public float processleistung;
        public int ram;
        public int festplatte;

        //Konstructur
        public Beuro(string ip_Adresse, string name, float processleistung, int ram, int festplatte) : base(name, ip_Adresse) 
        {
            this.processleistung = processleistung;
            this.ram = ram;
            this.festplatte = festplatte;
        }

        //Methode
        public override string ToString()
        {
            return base.ToString() + $"\nProzessor Leistung: {processleistung}\nRAM: {ram}\nGröße HDD: {festplatte}";
        }
    }

    class Grafische : Beuro
    {
        //Felder

        public float monitor;
        public string modellName;

        //Konstructur
        public Grafische(string name, string ip_Adresse, float processleistung, int ram, int festplatte, float monitor, string modellName) : base (name, ip_Adresse,processleistung, ram, festplatte)
        {
            this.monitor = monitor;
            this.modellName = modellName;
        }

        //Methode
        public override string ToString()
        {
            return base.ToString() + $"\nMonitorGröße: {monitor}\nGrafikkarte: {modellName}";
        }
    }

    class Server : Rechner
    {
        //Felder
        public float processLeistung;
        public int processAnzahl;
        public int ram;
        public int festplatte;
        public int anzahlFestplatte;
        public string funkiotion;
        public int netzwerkLeistung;

        //Konstructur
        public Server(string name, string ip_Adresse, float processLeistung, int processAnzahl, int ram, int festplatte, int anzahlFestplatte, string funkiotion, int netzwerkLeistung) : base (name, ip_Adresse)
        {
            this.processLeistung = processLeistung;
            this.processAnzahl = processAnzahl;
            this.ram = ram;
            this.festplatte = festplatte;
            this.anzahlFestplatte = anzahlFestplatte;
            this.funkiotion = funkiotion;
            this.netzwerkLeistung = netzwerkLeistung;
        }
        //Methode
        public override string ToString()
        {
            return base.ToString() + $"\nProzessor Leistung: {processLeistung}\nProzesssor Anzahl: {processAnzahl}\nRAM: {ram}\nHDD:{festplatte}\nAnzahl HDD: {anzahlFestplatte}\nFunktion: {funkiotion}\nNetz Leistung: {netzwerkLeistung}";
        }
    }

    class Terminal : Rechner
    {
        //Felder
        public string standOrt;
        public Server referenz;

            //Konstructur
         public Terminal(string ip_Adresse,string name,string standOrt, Server referenz) : base(name, ip_Adresse)
        {
            this.standOrt = standOrt;
            this.referenz = referenz;
        }

        //Methode
        public override string ToString()
        {
            return base.ToString() + $"Standort: {standOrt}\n Server: {referenz.name}";
        }
    }

}
