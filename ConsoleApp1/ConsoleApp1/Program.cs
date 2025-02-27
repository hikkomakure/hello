using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите свое имя");
        int name = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите свой возраст");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите свой город");
        int gorod = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"привет {name}, тебе {age} и ты проживаешь в этом {gorod}");
    }

}


