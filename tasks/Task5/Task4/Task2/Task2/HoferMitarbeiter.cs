using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class HoferMitarbeiter : IMitarbeiter
    {
        //Private Fields
        private string _firstname;
        private string _lastname;
        private int _svn;
        private double _salary;
        private double _popularity;

        //Constructor
        public HoferMitarbeiter(string firstname, string lastname, int svn, double salary)
        {
            if (string.IsNullOrWhiteSpace(firstname)) throw new ArgumentException("Firstname is empty!", nameof(firstname));
            if (string.IsNullOrWhiteSpace(lastname)) throw new ArgumentException("Lastname is empty!", nameof(lastname));
            if (svn.ToString().Length != 4) throw new ArgumentException("SVN must be 4 digits!", nameof(svn));
            if (salary < 0) throw new ArgumentException("Salary must be greater than 0!", nameof(salary));
              
            _firstname = firstname;
            _lastname = lastname;
            _svn = svn;
            _salary = salary;
        }

        public string firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public double popularity
        {
            get
            {
                return _popularity;
            }
            set
            {
                _popularity = value;
            }
        }

        public double salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }

        public int svn
        {
            get
            {
                return _svn;
            }
            set
            {
                _svn = value;
            }
        }

        public void changefirstname()
        {
            Console.WriteLine("New Firstname: ");
            var name = Console.ReadLine();
            firstname = name;
        }

        public void changelastname()
        {
            Console.WriteLine("New lastname: ");
            var name = Console.ReadLine();
            lastname = name;
        }

        public void popularity_rate(double value)
        {
            if (value < 5) popularity = popularity + 10;
            else if (value >= 10) popularity = popularity - 10;
        }

        public void promote(double salary)
        {
            Console.WriteLine("Promotion in %: ");
            var tmp = Convert.ToDouble(Console.ReadLine());
            if (tmp <= 5) popularity_rate(tmp);
            else popularity_rate(tmp);
            this.salary *= ((tmp+100)/100);              
        }
    }
}
