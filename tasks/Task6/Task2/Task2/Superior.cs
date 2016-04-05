using System;

namespace Task2
{
    class Superior : IMitarbeiter
    {
        //Private Fields
        private string firstname;
        private string lastname;

        //Constructor
        public Superior(string firstname, string lastname, int svn, double salary, double popularity)
        {
            if (string.IsNullOrWhiteSpace(firstname)) throw new ArgumentException("Firstname is empty!", nameof(firstname));
            if (string.IsNullOrWhiteSpace(lastname)) throw new ArgumentException("Lastname is empty!", nameof(lastname));
            if (svn.ToString().Length != 4) throw new ArgumentException("SVN must be 4 digits!", nameof(svn));
            if (salary < 0) throw new ArgumentException("Salary must be greater than 0!", nameof(salary));

            this.firstname = firstname;
            this.lastname = lastname;
            this.Svn = svn;
            this.Salary = salary;
            this.Popularity = popularity;
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

        /// <summary>
        /// changes firstname
        /// </summary>
        /// <returns></returns>
        public void changeFirstname()
        {
            Console.WriteLine("New Firstname: ");
            var name = Console.ReadLine();
            this.firstname = name;
        }

        /// <summary>
        /// Changes the lastname
        /// </summary>
        /// <returns></returns>
        public void changeLastname()
        {
            Console.WriteLine("New lastname: ");
            var name = Console.ReadLine();
            this.lastname = name;
        }

        /// <summary>
        /// Increases the salary by given %
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public void promote(double salary)
        {
            Console.WriteLine("Promotion in %: ");
            var tmp = Convert.ToDouble(Console.ReadLine());
            if (tmp <= 5) popularityRate(tmp);
            else popularityRate(tmp);
            Salary *= ((tmp + 100) / 100);
        }

        /// <summary>
        /// Superior popularity decreases if promotion bigger then 10%
        /// Supperior popularity increases if promotion smaller then 5%
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void popularityRate(double value)
        {
            if (value < 5) Popularity = Popularity + 10;
            else if (value >= 10) Popularity = Popularity - 10;
        }
    }
}
