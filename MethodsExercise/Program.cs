using System.ComponentModel;

namespace MethodsExercise
{
    class Program
    {
        
        //5 parts of a method: 1. access modifier 2. return type 3.Method Name 4. Parameters List 5. Scope
        //exercise 2
        public static int Sum(params int[] numbers)
        {
            int total = 0; //initializing vaiable for return int data to be saved.
            foreach (int number in numbers)
            {
                total += number;
            }

            return total;

        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine((10, 20, 3, 5, 7, -10, 11, 12, 13, -1)); //ALWAYS call the method in main by its name,
                                                                          //must give arguments when the method has parameters
            Console.WriteLine(Multiply(10, 20));
            //exercise 1
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine($"Hello,{name}! Welcome to Linked Stables\n" +
                "Iowa's #1 Horse Barn. How long will you be riding today?");
            string hours = Console.ReadLine(); 
            
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine(); 
            
            Console.WriteLine("What is your height?");
            string height = Console.ReadLine(); 
            
            Console.WriteLine($"Ok {name}, for your age of {age} and height of {height}, I will direct you to stall 7 with our horse Bailey\n" +
                              $"where you will be riding for {hours}");
            
            
        }
    }
}
