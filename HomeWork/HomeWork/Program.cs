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
            Random rnd = new Random();
            for (int i = 0;i < 20; i++)
            {
                array[i] = rnd.Next(-30, 30);
            }
            foreach (var c in array)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
