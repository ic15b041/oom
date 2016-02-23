using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Mitarbeiter
    {
        //Fields
        string vorname;
        string nachname;
        int svn;

        //Properties
        public string Vorname
        {
            get { return this.vorname; }
        }
        public string Nachname
        {
            get { return this.nachname; }
        }
        //Read-only
        public int SVN
        {
            get { return this.svn; }
        }


        //Constructor, setzt die Inhalte aus der Main in die Fields
        public Mitarbeiter(string vorname, string nachname, int svn)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.svn = svn;
        }

        //Methode um den Nachname zu aendern
        public string changelastname(string nachname)
        {
            return this.nachname = nachname;
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter m1 = new Mitarbeiter("David", "Boisits", 1234);
            Mitarbeiter m2 = new Mitarbeiter("Markus", "Diewald", 2345);
            Mitarbeiter m3 = new Mitarbeiter("Peter", "Huber", 4734);

            //Mitarbeiter ausgeben
            Console.WriteLine("Vorname: " + m1.Vorname + " " + "Nachname: " + m1.Nachname + " " + "SVN: " + m1.SVN);
            Console.WriteLine("Vorname: " + m2.Vorname + " " + "Nachname: " + m2.Nachname + " " + "SVN: " + m2.SVN);
            Console.WriteLine("Vorname: " + m3.Vorname + " " + "Nachname: " + m3.Nachname + " " + "SVN: " + m3.SVN);

            Console.WriteLine();
            Console.WriteLine("Aendere die Nachnamen!");
            Console.WriteLine();

            m1.changelastname("Boisitsneu");
            m2.changelastname("Diewaldneu");
            m3.changelastname("Huberneu");

            Console.WriteLine("Vorname: " + m1.Vorname + " " + "Nachname: " + m1.Nachname + " " + "SVN: " + m1.SVN);
            Console.WriteLine("Vorname: " + m2.Vorname + " " + "Nachname: " + m2.Nachname + " " + "SVN: " + m2.SVN);
            Console.WriteLine("Vorname: " + m3.Vorname + " " + "Nachname: " + m3.Nachname + " " + "SVN: " + m3.SVN);
        }
    }
}
