using System;

/*
 LAB4
Використовуючи інтерфейси або спадкування реалізуйте еволюцію: дисковий телефон -> кнопочний телефон –>мобільний телефон з чорно-> білим екраном – >мобільний телефон з кольоровим екраном – >смартфон. (краще спадкування)

 */

namespace work_8
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone p1 = new SmartPhone("12345", "12456789", 10, 10, 2.5, ConsoleColor.Red, 10, 2);
            Console.WriteLine(p1.Number);
            p1.ShowSymbols();
            p1.CallTo(1, "12345");
            p1.CallTo(2, "123");
            p1.CallFrom("321");

            p1.DropCall();
            p1.CallFrom("2");
            p1.DropCall();
            Console.WriteLine("*********************************************************");
            p1.SendMessage(2, "123", "hello", "world");
            p1.GetMessage("12345");
            Console.WriteLine("*********************************************************");
            p1.SendMMS(2, "43", "h", "w", "file.txt");
            p1.GetMMS("Stas");
            Console.WriteLine("*********************************************************");
            p1.create_movie(3);
            p1.create_photo(1);


        }
    }
}
