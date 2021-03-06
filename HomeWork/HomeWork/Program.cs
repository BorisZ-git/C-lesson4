﻿using System;
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

            //Test(Тест)
            int[] array = new int[5] {6,2,9,-3,6};
            ArrayCount(array);
            //Solution(Решение)
            int[] array2 = new int[20];
            ArrayFull(array2);
            ArrayCount(array2);
            //Pause(Пауза)
            Console.ReadLine();

        }
        //Метод который считает пары
        static void ArrayCount(int[] array)
        {
            int Answer = 0;
            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = i; j < i + 2; j++)
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
        }
        //Метод заполняющий элементы массива
        static void ArrayFull(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }
        }
    }
}
