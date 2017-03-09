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


namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {            
            string login = Console.ReadLine();
            string password = Console.ReadLine();
            
            string[] vLogin = VerData("login.txt");
            string[] vPassword = VerData("password.txt");
            for (int i = 0; i < vLogin.Length; i++)
            {
                if (login == vLogin[i])
                {
                    for (int j = 0; j <vPassword.Length; j++)
                    {
                        if (password == vPassword[j])
                        {
                            Console.WriteLine("Добро пожаловать!");
                            break;
                        }
                    }
                }
            }

            Console.ReadLine();

        }
        static string[] VerData(string filename)
        {                
            StreamReader srVerify = new StreamReader(filename);
            string[] verify = new string[Count(filename)];
            for (int i = 0; i<verify.Length; i++)
            {
                verify[i] = srVerify.ReadLine();
            }
            srVerify.Close();

            return verify;
        }
        static int Count(string filename)
        {
            int count = 0;
            StreamReader srVerify = new StreamReader(filename);
            while (!srVerify.EndOfStream)
            {
                srVerify.ReadLine();
                count++;
            }
            srVerify.Close();
            return count;
        }        
    }
}
