using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
     
        static void Main(string[] args)
        {
            
            double[,] mas = new double[10, 10];
            Random rand = new Random();
            
            for(int i=0;i<10;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas[i, j] = rand.Next(1, 9);
                    mas[i,j]/=10;
                  if (i == j)
                        mas[i, j] /= -1;
                }
            }

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write(mas[i, j].ToString() + " ");
                Console.WriteLine();
            }
            
                double max = -1000;
            double[] maxValues = new double[mas.GetLength(0)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, i] < 0)
                    {
                        if (mas[i, j] > max)
                        {
                            max = mas[i, j];
                            maxValues[i] = max;
                        }
                    }
                }
                max = -1000;
            }
          
            for (int i = 0; i < maxValues.Length; i++)
            {
                if (maxValues[i] == 0)
                {
                    Console.WriteLine($"В строке {i + 1}: главная диагональ не имеет отрицательного элемента");
                }
                else
                {
                    Console.WriteLine($"В строке {i + 1}: максимальный элемент {maxValues[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
