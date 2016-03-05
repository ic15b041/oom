using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class HoferMitarbeiter : IMitarbeiter
    {
        //Constructor
        public HoferMitarbeiter(string firstname, string lastname, int svn, double salary)
        {
            if (string.IsNullOrWhiteSpace(firstname)) throw new ArgumentException("Firstname is empty!", nameof(firstname));
            if (string.IsNullOrWhiteSpace(lastname)) throw new ArgumentException("Lastname is empty!", nameof(lastname));
            if (svn.ToString().Length != 4) throw new ArgumentException("SVN must be 4 digits!", nameof(svn));
            if (salary < 0) throw new ArgumentException("Salary must be greater than 0!", nameof(salary));
              
            this.firstname = firstname;
            this.lastname = lastname;
            this.svn = svn;
            this.salary = salary;
        }

        public string firstname
        {
            get; set;
        }

        public string lastname
        {
            get; set;
        }

        public double popularity
        {
            get; set;
        }

        public double salary
        {
            get; set;
        }

        public int svn
        {
            get;
        }

        public string changefirstname()
        {
            Console.WriteLine("New Firstname: ");
            var name = Console.ReadLine();
            return this.firstname = name;
        }

        public string changelastname()
        {
            Console.WriteLine("New lastname: ");
            var name = Console.ReadLine();
            return this.lastname = name;
        }

        public double popularity_rate(double value)
        {
            if (value < 5) return (popularity = popularity + 10);
            else if (value >= 10) return (popularity = popularity - 10);
            else return popularity;
        }

        public double promote(double salary)
        {
            Console.WriteLine("Promotion in %: ");
            var tmp = Convert.ToDouble(Console.ReadLine());
            if (tmp <= 5) popularity_rate(tmp);
            else popularity_rate(tmp);
            return salary * ((tmp+100)/100);                   
        }
    }
}
