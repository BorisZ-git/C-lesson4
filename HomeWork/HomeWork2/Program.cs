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
 /* Очень простанственно пишутся задания: Вот 2.2 Какие данные он считывать должен,
  * какие записывать. 2.1 Sum всех элементов или выборочно по индексу?  maxCount это сколько
  * элементов в массиве или наибольший элемент? 
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
            //Конструктор получающий данные из файла
            public MyArray(string filename)
            {
                StreamReader sr = new StreamReader("data.txt");
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
            public MyArray(string filename, int min, int max)
            {

            }
            //Добавить элемент массива в файл(увеличиваем массив)
            public void AddElement (string filename)
            {

            }


            #endregion
        }
        static void Main(string[] args)
        {
            //2.1

            MyArray array = new MyArray(5,1);
            Console.WriteLine($"Сумма: {array.Sum()}");
            array.Multi(2);
            array.Inverse();
            array.ShowArray();

            Console.WriteLine($"Кол-во элементов: {array.MaxCount()}");
            array.Inverse();
            array.ShowArray();

            //2.2

            Console.ReadLine();
        }
    }
}
