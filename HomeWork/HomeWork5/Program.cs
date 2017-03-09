using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * **Существует алгоритмическая игра “Удвоитель”. 
 * В этой игре человеку предлагается какое-то число, а человек должен, 
 * управляя роботом “Удвоитель”, достичь этого числа за минимальное число шагов. 
 * Робот умеет выполнять несколько команд: увеличить число на 1, умножить число на 2 и 
 * сбросить число до 1. Начальное значение удвоителя равно 1.   
 * Реализовать класс “Удвоитель”.  Класс хранит в себе поле current - текущее значение, 
 * finish - число, которого нужно достичь, конструктор, в котором задается конечное число. 
 * Методы: увеличить число на 1, увеличить число в два раза, сброс текущего до 1, 
 * свойство Current, которое возвращает текущее значение, свойство Finish,которое 
 * возвращает конечное значение.  Создать с помощью этого класса игру, в которой 
 * компьютер загадывает число, а человек. выбирая из меню на экране, отдает команды 
 * удвоителю и старается получить это число за наименьшее число ходов. 
 * Если человек получает число больше положенного, игра прекращается.
 * */

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int UserAnswer = 0;
            Doubler doubler = new Doubler(rnd.Next(30,100));
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Необходимо набрать:{doubler.Finish()}\t"
                    + $"сейчас: {doubler.Current()}\t Осталось ходов: {10-i}");
                Console.WriteLine("Выберите действия: 1.Увеличить число на один\t"+
                    "2.Умножить на два\t3.Сбросить до одного");
                Console.ResetColor();
                int.TryParse(Console.ReadLine(), out UserAnswer);
                if (UserAnswer == 1) doubler.Increase();
                if (UserAnswer == 2) doubler.Multi();
                if (UserAnswer == 3) doubler.Reset();
                if (doubler.Current() == doubler.Finish())
                {
                    Console.WriteLine($"Вы победили за {i} ходов!");
                    Console.ReadLine();
                    break;
                }
                if (doubler.Current()>doubler.Finish())
                {
                    Console.WriteLine($"Перебор =(");
                    Console.ReadLine();
                    break;
                }
            }

        }
    }
}
