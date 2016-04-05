using System;
using System.IO;
using Newtonsoft.Json;
using System.Reactive.Linq;
using System.Reactive.Subjects;


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
                new HoferMitarbeiter("Peter", "Huber", 1235, 3000),
                new Superior("Manuel", "Koch", 1111, 5000, 100.0),
                new Superior("Silvia", "Koch", 2222, 4000, 60.0),
            };

            var producer = new Subject<HoferMitarbeiter>();
            producer.Subscribe(x => Console.WriteLine($"received value {x.Salary}"));

            for(var i=0; i<10; i++)
            {
                var random = new Random();
                producer.OnNext
            }


            string json = JsonConvert.SerializeObject(employee);
            string path = @"C:\Users\David\Desktop\Json.txt";
            if(!File.Exists(path))
            {
                File.WriteAllText(path, json);
            }
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.WriteLine();
            
            foreach(var x in employee)
            {                
                Console.Write("Firstname: " + x.Firstname + " " + "Lastname: " + x.Lastname + " " + "SVN: " + x.Svn + " " + "Salary: " + x.Salary + " ");
                if (x is Superior)
                {
                    var sup = (Superior)x;
                    Console.Write("Popularity: " + sup.Popularity);                    
                }
                Console.WriteLine();
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
                            if (tmp == x.Svn) x.changeFirstname();                         
                        }
                        break;                       
                    }
                case 2:
                    {
                        Console.WriteLine("Which persons lastname do you want to change? SVN: ");
                        tmp = Convert.ToInt32(Console.ReadLine());

                        foreach (var x in employee)
                        {
                            if (tmp == x.Svn) x.changeLastname();
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Which persons do you want to promote? SVN: ");
                        tmp = Convert.ToInt32(Console.ReadLine());

                        foreach (var x in employee)
                        {
                            if (tmp == x.Svn)
                            {
                                x.promote(x.Salary);
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
                Console.WriteLine("Firstname: " + x.Firstname + " " + "Lastname: " + x.Lastname + " " + "SVN: " + x.Svn + " " + "Salary: " + x.Salary + " " + "Popularity: " + x.Popularity);
            }
        }
    }
}
