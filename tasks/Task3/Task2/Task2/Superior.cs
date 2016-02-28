using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Superior : IMitarbeiter
    {
        public Superior(string firstname, string lastname, int svn, double salary, double popularity)
        {
            if (string.IsNullOrWhiteSpace(firstname)) throw new ArgumentException("Firstname is empty!", nameof(firstname));
            if (string.IsNullOrWhiteSpace(lastname)) throw new ArgumentException("Lastname is empty!", nameof(lastname));

            this.firstname = firstname;
            this.lastname = lastname;
            this.svn = svn;
            this.salary = salary;
            this.popularity = popularity;
        }

        public string firstname
        {
            get; set;
        }

        public string lastname
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

        public double popularity
        {
            get; set;
        }

        /// <summary>
        /// changes firstname
        /// </summary>
        /// <returns>changed firstname</returns>
        public string changefirstname()
        {
            Console.WriteLine("New Firstname: ");
            var name = Console.ReadLine();
            return this.firstname = name;
        }

        /// <summary>
        /// Changes the lastname
        /// </summary>
        /// <returns>changed lastname</returns>
        public string changelastname()
        {
            Console.WriteLine("New lastname: ");
            var name = Console.ReadLine();
            return this.lastname = name;
        }

        /// <summary>
        /// Increases the salary by given %
        /// </summary>
        /// <param name="salary"></param>
        /// <returns>promoted salary</returns>
        public double promote(double salary)
        {
            Console.WriteLine("Promotion in %: ");
            var tmp = Convert.ToDouble(Console.ReadLine());
            if (tmp <= 5) popularity_rate(tmp);
            else popularity_rate(tmp);
            return salary * ((tmp + 100) / 100);
        }

        /// <summary>
        /// Superior popularity decreases if promotion bigger then 10%
        /// Supperior popularity increases if promotion smaller then 5%
        /// </summary>
        /// <param name="value"></param>
        /// <returns>popularity</returns>
        public double popularity_rate(double value)
        {
            if (value < 5) return (popularity = popularity + 10);
            else if (value >= 10) return (popularity = popularity - 10);
            else return popularity;
        }
    }
}
