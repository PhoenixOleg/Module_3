using System;

namespace Task_3_2_3
{
    enum Semaphore : int
    {
        Red = 100
        , Yellow = 200
        , Green = 300
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Предварительные задания и свои эксперименты по Модулю 3
            //Tasks();
            Console.WriteLine("Итоговое задание Модуля 3");

            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");


            var age = checked((byte)int.Parse(Console.ReadLine()));

            //Тут почитал https://learn.microsoft.com/ + практика на vb.net
            DateTime dtBirth;
            bool result;
            Console.Write("Введите Вашу дату рождения: ");
            result = DateTime.TryParse(Console.ReadLine(), out dtBirth);

            if (result == false)
                Console.WriteLine("Вы ввели некорректное значение даты. Запустите программу повторно.");
            else
            {
                Console.WriteLine("\nЗдравствуйте, " + name);
                Console.WriteLine("Вам {0} лет", age);
                Console.WriteLine($"Выродились {dtBirth:dd.MM.yyyy}");
            }

            Console.ReadKey();

        }

        static void Tasks()
        {

            Console.WriteLine("Это предварительные задания и свои эксперименты по Модулю 3");
            Console.WriteLine("Закоментированы запросы на ввод и дублирующиеся объявления\n");

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
            byte MyAge = 44;
            Boolean IsHavePet = false;
            double MyShoeSize = 44;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do i have pet? " + IsHavePet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.WriteLine("\n");
            Console.WriteLine("Int min value " + int.MinValue);
            Console.WriteLine("Int max value " + int.MaxValue);
            Console.WriteLine("\n");
            Console.WriteLine("Dec min value {0}", decimal.MinValue); ;
            Console.WriteLine("Dec max value {0}", decimal.MaxValue);

            Console.WriteLine("\n");
            Console.WriteLine(Semaphore.Red);

            //Задание 3.5.2
            Console.WriteLine("\n");
            Console.WriteLine("\tПривет,\n мир!");

            Console.WriteLine("\n");
            MyName = "Олег";
            Console.WriteLine("Привет, мир");
            Console.WriteLine();
            Console.WriteLine("Меня зовут " + MyName);
            Console.WriteLine("Меня зовут {0}", MyName); //плейсхолдер
            Console.WriteLine($"Меня зовут {MyName}"); //интерполяция

            Console.WriteLine("\n");
            byte Age = 44;
            Console.WriteLine($"Мой возраст {Age}");

            //Задание 3.5.4
            Console.WriteLine("\n");
            string name = "Oleg";
            byte age = 44;
            string favcolor = "black";

            Console.WriteLine("{0} \n {1} \n {2}", name, age, favcolor);

            // чтоб не мешало запросом
            ////Задание 3.5.5
            ////string str;
            ////str = Console.ReadLine();
            //Console.WriteLine("\n");
            //string str = Console.ReadLine();
            //Console.WriteLine(str);

            //Console.WriteLine("\n");
            //double result = 5.0 % 2.0;
            //Console.WriteLine("5 % 2 = {0}", result);

            //double result_int = 5 % 2;
            //Console.WriteLine("5 % 2 = {0}", result_int);


            //int counter = 10;
            //Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter); //Префиксная - увеличили (++ впереди). а затем вывели

            //int counter1 = 10;
            //Console.WriteLine("Value: {0} Increment: {1}", counter1, counter1++); //Постфиксная - вывели, а потом только увеличили (++ сзади). Тут 10
            //Console.WriteLine(counter1); //А тут уже 11. Уже увеличена

            //Задание 3.6.3
            //double result = 5.0 / 2.0 * 3.0;
            //Console.WriteLine("5 / 2 * 3 = " + result);


            //Задание 3.6.5

            int b = 5;
            int k = -7;
            b = b - k;
            Console.WriteLine(b);

            //Задание 3.6.7
            double result = 10 % 3;
            Console.WriteLine(result);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);

            //Задание 3.7.3
            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age1 = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name1, age1);

            //Parse не падает в ошибку если идет усечение данных. но падает. если приобразование невозможно в принципе - строка символов в число (44r -> error)

            //Задание 3.7.4
            Console.Write("Введите номер Ваше любимого дня недели (0-6) ");
            DayOfWeek NameDayOfWeek = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш любимый день недели {0}", NameDayOfWeek);

        }



    }
}
