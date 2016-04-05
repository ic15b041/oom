using System;

namespace Task2
{
    class HoferMitarbeiter : IMitarbeiter
    {
        //Private Fields
        private string firstname;
        private string lastname;

        //Constructor
        public HoferMitarbeiter(string firstname, string lastname, int svn, double salary)
        {
            if (string.IsNullOrWhiteSpace(firstname)) throw new ArgumentException("Firstname is empty!", nameof(firstname));
            if (string.IsNullOrWhiteSpace(lastname)) throw new ArgumentException("Lastname is empty!", nameof(lastname));
            if (svn.ToString().Length != 4) throw new ArgumentException("SVN must be 4 digits!", nameof(svn));
            if (salary < 0) throw new ArgumentException("Salary must be greater than 0!", nameof(salary));
              
            this.firstname = firstname;
            this.lastname = lastname;
            this.Svn = svn;
            this.Salary = salary;
        }

        public string Firstname
        {
            get { return firstname; }
        }

        public string Lastname
        {
            get { return lastname; }
        }

        public double Popularity
        {
            get; set;
        }

        public double Salary
        {
            get; set;
        }

        public int Svn
        {
            get; set;
        }

        //Greift auf Field zu
        public void changeFirstname()
        {
            Console.WriteLine("New Firstname: ");
            var name = Console.ReadLine();
            this.firstname = name;
        }

        public void changeLastname()
        {
            Console.WriteLine("New lastname: ");
            var name = Console.ReadLine();
            this.lastname = name;
        }

        //Greift auf Property zu
        public void popularityRate(double value)
        {
            if (value < 5) Popularity += 10;
            else if (value >= 10) Popularity -= 10;
        }

        public void promote(double salary)
        {
            Console.WriteLine("Promotion in %: ");
            var tmp = Convert.ToDouble(Console.ReadLine());
            if (tmp <= 5) popularityRate(tmp);
            else popularityRate(tmp);
            Salary *= ((tmp+100)/100);              
        }
    }
}