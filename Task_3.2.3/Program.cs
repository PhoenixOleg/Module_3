using System;

namespace Task_3_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            myName = "Oleg";

            Console.WriteLine(myName);
            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\t Привет, мир\n");
            Console.WriteLine("Привет,\n мир!");
            Console.WriteLine("\u0023");
            Console.WriteLine("\x23");
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(0x11);
            Console.WriteLine(0b10);
            Console.WriteLine(5.5);
            
            Console.WriteLine("\n");
            string MyName = "Oleg";
            byte Age = 44;
            Boolean IsHavePet = false;
            double MyShoeSize = 44;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + Age);
            Console.WriteLine("Do i have pet? " + IsHavePet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();
        }
    }
}
