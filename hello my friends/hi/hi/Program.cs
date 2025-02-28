using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите свое имя");
        string name = Console.ReadLine();
        Console.WriteLine("Введите свой возраст"); 
        string age = Console.ReadLine(); 
        Console.WriteLine("Введите свой город"); 
        string gorod = Console.ReadLine(); 
        Console.WriteLine($"привет {name}, тебе {age} и ты проживаешь в этом {gorod}");

    }

}
