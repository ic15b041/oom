using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int tmp;
            var employee = new IMitarbeiter[]
            {
                new HoferMitarbeiter("David", "Boisits", 1234, 2000),
                new HoferMitarbeiter("Peter", "Huber", 3456, 3000),
                new Superior("Manuel", "Koch", 1111, 5000, 100.0),
                new Superior("Silvia", "Koch", 2222, 4000, 60.0),
            };
            
            foreach(var x in employee)
            {
                Console.WriteLine("Firstname: " + x.firstname + " " + "Lastname: " + x.lastname + " " + "SVN: " + x.svn + " " + "Salary: " + x.salary + " " + "Popularity: " + x.popularity);
            }                 

            Console.WriteLine("1. Change FN | 2. Change LN | 3. Promote");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Which persons firstname do you want to change? SVN: ");
                        tmp = Convert.ToInt32(Console.ReadLine());
                       
                        foreach (var x in employee)
                        {
                            if (tmp == x.svn) x.changefirstname();                         
                        }
                        break;                       
                    }
                case 2:
                    {
                        Console.WriteLine("Which persons lastname do you want to change? SVN: ");
                        tmp = Convert.ToInt32(Console.ReadLine());

                        foreach (var x in employee)
                        {
                            if (tmp == x.svn) x.changelastname();
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Which persons do you want to promote? SVN: ");
                        tmp = Convert.ToInt32(Console.ReadLine());

                        foreach (var x in employee)
                        {
                            if (tmp == x.svn)
                            {
                                x.salary = x.promote(x.salary);
                            }
                           
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Input!");
                        break;                 
                    }
            }

            foreach (var x in employee)
            {
                Console.WriteLine("Firstname: " + x.firstname + " " + "Lastname: " + x.lastname + " " + "SVN: " + x.svn + " " + "Salary: " + x.salary + " " + "Popularity: " + x.popularity);
            }
        }
    }
}
