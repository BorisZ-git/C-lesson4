using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/* Boris Z
 * Есть задачка следующая: 
 * 1.1 Чертим на консоли квадрат по центру.
 * 1.2 И заставить курсор при приближении к границам квадрата отскакивать от них.
 * То есть курсор не может зайти в этот квадрат.
 * 1.3 Можно усовершенствовать программу по своему усмотрению.
 * */

namespace AdditionalTask
{
    class Program
    {
        static void Main()
        {
            //1.1
            string Hor = "**********";
            int StrHorLength, width, height, x, y;
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            StrHorLength = Hor.Length;
            x = (width - StrHorLength) / 2;
            y = height / 2;

            DrawLine(x, y, Hor);
            DrawLine(x, y + 5, Hor);

            DrawVerti(x, y);
            DrawVerti(x + 10, y);

            //1.2
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            do
            {
                Console.ReadLine();
                Console.SetCursorPosition(rnd.Next(50, 80), rnd.Next(10, 25));
                int CursorX = Console.CursorLeft;
                int CursorY = Console.CursorTop;
                Thread.Sleep(500);
                if (CursorX >= x & CursorX <= x + 10 & CursorY >= y & CursorY <= y + 5)
                {
                    Console.SetCursorPosition(rnd.Next(10, 45), rnd.Next(0, 10));
                    Console.WriteLine("Курсор попал в квадрат");
                    Thread.Sleep(500);
                    break;
                }
            } while (true);
            //1.3
            Console.Clear();
            Console.ResetColor();
            DrawLine(x, y, Hor);
            DrawLine(x, y + 5, Hor);

            DrawVerti(x, y);
            DrawVerti(x + 10, y);

            int aCursorX = 5;
            int aCursorY = 2;
            Console.SetCursorPosition(aCursorX, aCursorY);

            do
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        aCursorX -= 1;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        aCursorX += 1;
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                    {
                        aCursorY -= 1;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        aCursorY += 1;
                    }
                    Console.SetCursorPosition(aCursorX, aCursorY);
                }
                if (aCursorX >= x & aCursorX <= x + 10 & aCursorY >= y & aCursorY <= y + 5)
                {
                    aCursorX = rnd.Next(0, 10);
                    aCursorY = rnd.Next(0, 5); 
                    Console.SetCursorPosition(aCursorX, aCursorY);
                }
            } while (true);
        }
        static void DrawLine(int x, int y, string str)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
        static void DrawHoriz(int x, int y)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y);
                x++;
                Console.Write('*');
            }
        }
        static void DrawVerti(int x, int y)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(x, y);
                y++;
                Console.Write('*');
            }
        }
    }
}
