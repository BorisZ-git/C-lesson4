using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * Дан  целочисленный  массив  из 20 элементов.
 * Элементы  массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
 * Написать программу, позволяющую найти и вывести количество пар элементов массива,
 * в которых хотя бы одно число делится на 3.
 * В данной задаче под парой подразумевается два подряд идущих элемента массива.
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4. 
 * */

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int Answer = 0;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < i + 2; j++)
                {
                    if (j > array.Length) break;
                    else
                    {
                        if (array[j] % 3 == 0)
                        {
                                Answer++;
                        }
                    }
                }
                Console.WriteLine($"Ответ: {Answer}");
                foreach (var c in array)
                {
                    Console.WriteLine($"Элемент номер {c} равен: {c}");
                }
                Console.ReadLine();
            }
        }
    }
}
