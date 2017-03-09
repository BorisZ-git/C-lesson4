using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * 2.1 Дописать класс для работы с одномерным массивом.
 * Реализовать конструктор, создающий массив заданной размерности и 
 * заполняющий массив числами от начального значения с заданным шагом.
 * Создать свойство Sum, которые возвращают сумму элементов массива,
 * метод Inverse, меняющий знаки у всех элементов массива, 
 * Метод Multi, умножающий каждый элемент массива на определенное число,
 * свойство MaxCount, возвращающее количество максимальных элементов.
 * В Main продемонстрировать работу класса. 
 * 2.2*Добавить конструктор и методы, которые загружают данные из файла и 
 * записывают данные в файл
 * */

namespace HomeWork2
{
    class Program
    {
        class MyArray
        {
            int[] a;
            public MyArray(int n)
            {
                a = new int[n];
            }        
            public MyArray(int n, int value)
            {
                a = new int[n];
                for (int i = 0; i < a.Length; i++)
                {
                    Set(i, value);
                }
            }
            public int Get(int i)
            {
                return a[i];
            }                        
            public void Set(int i, int value)
            {
                a[i] = value;
            }
            // либо создаем индексируемое свойство
            public int this[int i]
            {
                get { return a[i]; }
                set { a[i] = value; }
            }
            // возвращают сумму элементов массива
            public int Sum()
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
            // Умножение на каждый элемент
            public void Multi(int n)
            {
                for (int i = 0;i< a.Length; i++)
                {
                    a[i] *= n;
                }
            }
            // Меняет знак у каждого элемента
            public void Inverse()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] *= -1;
                }
            }
            // Показать элементы
            public void ShowArray()
            {
                for (int i = 0; i<a.Length;i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            //MyArray array = new MyArray(5);
            //for (int i = 0; i < 5; i++) array[i] = i + 1;
            MyArray array = new MyArray(5,1);
            Console.WriteLine($"Сумма: {array.Sum()}");
            array.Multi(2);
            array.Inverse();
            array.ShowArray();
            
            Console.ReadLine();
            //2.1
        }
    }
}
