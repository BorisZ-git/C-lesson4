using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            #region 2.1

            int[] a;
            //Конструктор с длинной массива
            public MyArray(int n)
            {
                a = new int[n];
            }        
            //Конструктор с длинной и записью элементов
            public MyArray(int n, int value)
            {
                a = new int[n];
                for (int i = 0; i < a.Length; i++)
                {
                    Set(i, value);
                    a[i] += i;
                }
            }
            //Получить значение элемента
            public int Get(int i)
            {
                return a[i];
            }                        
            //Задать значение элемента
            public void Set(int i, int value)
            {
                a[i] = value;
            }
            // создаем индексируемое свойство
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
            // возвращает кол-во макс элементов
            public int MaxCount()
            {
                return a.Length;
            }
            // Показать элементы
            public void ShowArray()
            {
                for (int i = 0; i<a.Length;i++)
                {
                    Console.WriteLine($"Элемент {i+1}: {a[i]}");
                }
            }
            #endregion

            #region 2.2
            string[] b;
            //Конструктор получающий данные из файла
            public MyArray(string filename)
            {
                StreamReader sr = new StreamReader(filename);
                // Считываем количество элементов массива
                int N = int.Parse(sr.ReadLine());
                a = new int[N];
                // Считываем массив
                for (int i = 0; i < N; i++)
                {
                    a[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
            }
            //Конструктор записывающий массив в файл
            public MyArray(string filename,int n, int min, int max)
            {
                StreamReader sr = new StreamReader(filename);
                Random rnd = new Random();
                b = new string[n];
                for (int i = 0; i < n; i++)
                {
                    b[i] = Convert.ToString(rnd.Next(min, max));
                }
                sr.Close();
                System.IO.File.WriteAllLines(filename, b);
                
            }
            //Контсруктор получающий данные из перезаписанного файла
            public MyArray(string filename, int n)
            {
                StreamReader sr = new StreamReader(filename);
                a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
            }
            #endregion
        }
        static void Main(string[] args)
        {
            //2.1

            MyArray array = new MyArray(5, 1);
            Console.WriteLine($"Сумма: {array.Sum()}");
            array.Multi(2);
            array.Inverse();
            array.ShowArray();

            Console.WriteLine($"Кол-во элементов: {array.MaxCount()}");
            array.Inverse();
            array.ShowArray();

            //2.2
            Console.WriteLine("\nМассив из файла:");
            MyArray array2 = new MyArray("data.txt");
            array2.ShowArray();

            Console.WriteLine("\nМассив из перезаписанного файла:");
            MyArray _array = new MyArray("data2.txt", 6, 1, 10);
            MyArray array3 = new MyArray("data2.txt", CountString("data2.txt"));
            array3.ShowArray();

            array2.Multi(3);
            array3.Multi(3);
            Console.WriteLine();
            array2.ShowArray();
            Console.WriteLine();
            array3.ShowArray();


            Console.ReadLine();
        }
        //Метод считающий кол-во строк и передающий их как кол-во элеметов в массиве
        public static int CountString(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            int count = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                count++;
            }
            sr.Close();
            return count;
        }

    }
}
