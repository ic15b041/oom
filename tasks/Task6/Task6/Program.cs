using System;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.IO;
using System.Threading;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit;
            string name;

            //Starting the async task and testing await command
            Task asynctask = new Task(ProcessAsync);
            asynctask.Start();

            TextWriter tw = new StreamWriter(@"C:\Users\David\Desktop\workinghours.txt");

            //Shows the thread ID of the main program
            Console.WriteLine("Application thread ID: {0}",
                    Thread.CurrentThread.ManagedThreadId);         

            //Forces to insert something
            do
            {
                Console.WriteLine("Please insert your name:");
                name = Console.ReadLine();
            }
            while (name == "");


            do
            {
                //Execute some task examples
                task();
                //Run async method
                
                Console.WriteLine("Working time is recording!");
                //Create timestamps for every second
                var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Timestamp();

                //Print the timestamps to console
                using (observable.Subscribe(
                    x => Console.WriteLine("{0}: {1}", x.Value, x.Timestamp)))

                //Write the timestamps into a text file
                using (observable.Subscribe(
                    x => tw.WriteLine(name + ": " + Convert.ToString(x.Timestamp))))

                {
                    Console.WriteLine("Press any key to pause");
                    Console.ReadKey();
                }
                Console.WriteLine("(C)ontinue or (E)xit?");
                exit = Convert.ToChar(Console.ReadKey().KeyChar);
            }
            while (exit.Equals('c') || exit.Equals('C'));
            tw.Close();
        }

        //Executes the Calc() and Calc2() method
        static void task()
        {
            //Executes the calc function in a new task
            var firsttask = new Task(() => calc());
            //Continues with calc2
            var secondtask = firsttask.ContinueWith((t) => calc2());
            firsttask.Start();
        }

        //Simple calculation to test the new thread
        static void calc()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Task thread ID: {0}",
                Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("A * B = {0}",a*b);
        }

        //Simple calculation to test the new thread
        static void calc2()
        {
            int a = 10;
            int b = 5;

            Console.WriteLine("Task thread ID: {0}",
                Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("A - B = {0}", a - b);
        }

        //Runs async and is waiting for DoSomething method to finish
        static async void ProcessAsync()
        {
            Task<int> task = DoSomething(); 
            for(int i=0; i<10; i++)
            {
                int x = await task;
                await Task.Delay(5000);
                Console.WriteLine("Print all 5sec - async task!");
            }
               
        }

        //Blocks the ProcessAsync Method for 1sec
        static async Task<int> DoSomething()
        {
            await Task.Delay(1000);
            Console.WriteLine("Blocking the async process");
            return 0;
        }
    }    
}
