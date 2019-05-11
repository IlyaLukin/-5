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
            
            int[,] mas = new int[10, 10];
            Random rand = new Random();
            
            for(int i=0;i<10;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas[i, j] = rand.Next(1, 9);
                  
                }
            }

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write(mas[i, j].ToString() + " ");
                Console.WriteLine();
            }


            int maxElement = mas[0, 0];

            foreach (int element in mas)
            {
                if(maxElement<element)
                {
                    maxElement = element;
                }
            }

            Console.WriteLine($"Максимальный элемент матрицы {maxElement}");
            Console.ReadKey();
        }
    }
}
