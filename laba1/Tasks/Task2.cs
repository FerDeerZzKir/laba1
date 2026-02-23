using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace laba1.Tasks
{
    public static class Task2
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var dictionaries = new Dictionary<string, string>[]
            {
                new Dictionary<string, string>
                {
                    {"name", "Ivan"},
                    {"city", "Kyiv"},
                    {"age", "20"}
                },
                new Dictionary<string, string>
                {
                    {"name", "Kyryl"},
                    {"city", "Lviv"},
                    {"group", "FIOT"}
                },
                new Dictionary<string, string>
                {
                    {"card", "5168 7559 0383 9872"},
                    {"data", "09/28"},
                    {"cvv", "456"}
                }
            };

            Console.Write("Введіть ключ для пошуку: ");
            string searchKey = Console.ReadLine();


            var found = dictionaries
                .Where(dict => dict.ContainsKey(searchKey))
                .ToList();

            Console.WriteLine($"Знайдено словників: {found.Count}");

            foreach (var dict in found)
            {
                Console.WriteLine("-----");
                foreach (var pair in dict)
                {
                    Console.WriteLine($"{pair.Key} : {pair.Value}");
                }
            }
            Console.WriteLine("-----");


            if (found.Count > 0)
            {
                string json = JsonSerializer.Serialize(found, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                string path = Path.Combine("C:\\Users\\pozni\\source\\repos\\laba1\\laba1\\Tasks\\", "search_result.json");
                File.WriteAllText(path, json);
                Console.WriteLine("Результат збережено у файл search_result.json");
            }
        }
    }
}