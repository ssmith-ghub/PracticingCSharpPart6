using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?"); //if you want the user to know what you want as input then you must place this before the Console.ReadLine()
            string name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old!");//if incorrect data type is used then an exception is created.  Will come back to exceptions later  
        }
    }
}
