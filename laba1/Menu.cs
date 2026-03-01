using System;
using System.Text;
namespace laba1.Tasks;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Оберить завдання (Варіант 14):");
        Console.WriteLine("1 - Наближене R");
        Console.WriteLine("2 - Пошук по ключахххх");
        Console.WriteLine("3 - фул LINQ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Task1.Run();
                break;
            case "2":
                Task2.Run();
                break;
            case "3":
                Task3.Run();
                break;
            default:
                Console.WriteLine("Неверный выбор");
                break;
        }
    }


}