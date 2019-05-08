using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
  

    class Program
    {
        static int ReadIntNumber(string StringForUser, int min_size, int max_size)
        {
            bool ok = false;
            int number = 0;

            do
            {
                Console.WriteLine(StringForUser);
                try
                {
                    string off = Console.ReadLine();
                    number = Convert.ToInt32(off);

                    if (number >= min_size && number < max_size) ok = true;
                    else
                    {
                        Console.WriteLine("Число введено не верно!");
                        ok = false;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Число введено не верно!");
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Число введено не верно!");
                    ok = false;
                }
            } while (!ok);
            return number;
        }

        static Random rnd = new Random();
        const int min_size = 1;
        const int max_size = 10;
     
        static void Main(string[] args)
        {
            int [,] matr;
            int i, j;
            int stringSize = ReadIntNumber("Введите количество строк матрицы", min_size, max_size);
            int columnSize = ReadIntNumber("Введите количество столбцов матрицы", min_size, max_size);


            matr = new int[stringSize, columnSize];
            for (i = 0; i < stringSize; i++)
                for (j = 0; j < columnSize; j++)
                {
                    matr[i, j] = rnd.Next(-100, 100);
                }
            Console.WriteLine($"Матрица создана {matr} ");

        }
    }
}
