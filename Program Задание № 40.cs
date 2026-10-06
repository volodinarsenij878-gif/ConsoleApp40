using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program40
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Попробуем распарсить ввод как float
            Console.Write("Введите значение (float):");
            string input = Console.ReadLine();

            if (float.TryParse(input, out float f))
            {
                Console.WriteLine($"Значение: {f}");
                Console.WriteLine($"IsInfinity: {float.IsInfinity(f)}");
                Console.WriteLine($"IsNaN: {float.IsNaN(f)}");
            }
            else
            {
                // Если TryParse не сработал, пробуем явно ввести Infinity/NaN
                Console.WriteLine("Не удалось распарсить как float.");
                Console.WriteLine("Подсказка: для проверки используйте float.PositiveInfinity, float.NegativeInfinity или float.NaN в коде.");

                input = Console.ReadLine(); // Считываем новую строку

                if (float.TryParse(input, out f))
                {
                    Console.WriteLine($"Значение: {f}");
                    Console.WriteLine($"IsInfinity: {float.IsInfinity(f)}");
                    Console.WriteLine($"IsNaN: {float.IsNaN(f)}");
                }
                else
                {
                    Console.WriteLine("Даже явное указание Infinity/NaN не удалось распарсить.");
                }
            }

            // Демонстрация значений Infinity и NaN
            float posInf = float.PositiveInfinity;
            float negInf = float.NegativeInfinity;
            float nan = float.NaN;

            Console.WriteLine("\n--- Демонстрация значений ---");
            Console.WriteLine($"PositiveInfinity: IsInfinity={float.IsInfinity(posInf)}, IsNaN={float.IsNaN(posInf)}");
            Console.WriteLine($"NegativeInfinity: IsInfinity={float.IsInfinity(negInf)}, IsNaN={float.IsNaN(negInf)}");
            Console.WriteLine($"NaN: IsInfinity={float.IsInfinity(nan)}, IsNaN={float.IsNaN(nan)}");

            Console.ReadKey(); // Чтобы консоль не закрывалась сразу
        }
    }
}
