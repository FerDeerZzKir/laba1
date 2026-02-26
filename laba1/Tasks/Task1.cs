using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1.Tasks
{
    public class Task1
    {
        public static void Run() { 
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<double> I = new List<double> { 12, 1.0, 1.5, 2.0, 2.5 };
            List<double> U = new List<double> { 1.1, 2.1, 3.2, 4.1, 5.2 };

            if (I.Count != U.Count)
            {
                Console.WriteLine("Списки мають різну довжину!");
                return;
            }

            // Метод найменших квадратів
            double sumIU = I.Zip(U, (i, u) => i * u).Sum();
            double sumII = I.Select(i => i * i).Sum();

            

            double R = sumIU / sumII;

            Console.WriteLine($"R ≈ {R:F4} Ом");
        }
    }
}
