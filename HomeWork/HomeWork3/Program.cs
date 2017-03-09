using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/* Boris Z
 * Решить задачу с логинами из предыдущего урока,
 * только логины и пароли считать из файла в массив. 
 * */
 // Добавим файл в ресурсы

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {            
            string login = Console.ReadLine();
            string password = Console.ReadLine();
            string[] vLogin = VerData(Properties.Resources.login);
            string[] vPassword = VerData(Properties.Resources.password);
            if (login == "1" ) {; }

        }
        static string[] VerData(string filename)
        {
            int count = 0;                        
            StreamReader srVerify = new StreamReader(filename);
            while (!srVerify.EndOfStream)
            {
                srVerify.ReadLine();
                count++;
            }
            string[] verify = new string[count];
            for (int i = 0; !srVerify.EndOfStream; i++)
            {
                verify[i] = srVerify.ReadLine();
            }
            return verify;
        }        
    }
}
