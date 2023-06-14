

using System;

namespace Задание___6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            bool reverseOrder;

            try
            {
                if (args.Length >= 2)
                {
                    name = args[0];
                    reverseOrder = bool.Parse(args[1]);
                }
                else
                {
                    Console.WriteLine("Введите имя:");
                    name = Console.ReadLine();
                    Console.WriteLine("Введите порядок вывода имени (- для обратного порядка):");
                    reverseOrder = Console.ReadLine() == "-";
                }

                if (reverseOrder)
                {
                    for (int i = name.Length - 1; i >= 0; i--)
                    {
                        Console.Write(name[i]);
                    }
                }
                else
                {
                    Console.WriteLine(name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}

