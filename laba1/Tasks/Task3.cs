using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba1.Tasks
{
    public class Task3
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<string> strings = new List<string>
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five"
            };

            // - Select, SelectMany, Where

            var result = strings.Select(x => x.Count() % 2 != 1 ? x.FirstOrDefault() : x.LastOrDefault());
            var sortedByAscii = result.OrderByDescending(c => (int)c).ToList();
          
            Console.WriteLine("Отримані символи (за спаданням ASCII):");

            for (int i = 0; i < sortedByAscii.Count; i++)
            {
                Console.WriteLine($"{strings[i]} {sortedByAscii[i]} (ASCII {(int)sortedByAscii[i]})");
            }












        }
    }
}