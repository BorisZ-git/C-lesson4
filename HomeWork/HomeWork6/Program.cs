using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
/* Boris Z
* ***Написать игру “Верю. Не верю”.
*  В файле хранятся некоторые данные и правда это или нет. 
*  Например: “Шариковую ручку изобрели в древнем Египте”, “Да”. 
*  Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задает их игроку. 
*  Игрок пытается ответить правда или нет, то что ему загадали и набирает баллы. 
*  Список вопросов ищите во вложении или можно воспользоваться Интернетом.
* */

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем файл с вопросами и ответами
            CreateFile();
            //переменная для очков
            int points = 0;
            //объявляем документ
            var document = XDocument.Load(Environment.CurrentDirectory + @"\questions.xml");
            //Создаем массив или список
            var list = new List<XmlData>();
            //добавляем в список элементы из файла
            foreach (var i in document.Element("body").Elements("questions"))
            {
                list.Add(new XmlData() { question = i.Attribute("question").Value,
                    answer = i.Attribute("answer").Value });
            }
            Random rnd = new Random();
            //переменные для цикла
            int steps = 0;
            bool flag = true;
            while (flag == true)
            {
                int i = rnd.Next(0, 9);
                Console.WriteLine(list[i].question);
                var UserAnswer = Console.ReadLine();
                if (UserAnswer == list[i].answer)
                    points += 5; 
                else
                    Console.WriteLine("Ответ неверный");
                steps++;
                if (steps >= 5) flag = false;
            }
            Console.WriteLine($"Ваши очки = {points}");
            Console.ReadLine();
        }
        static void CreateFile()
        {
            // создание файла.
            XDocument xDoc = new XDocument(new XElement("body",
                new XElement("questions", new XAttribute("question", "В Древнем Риме альбомом называли доску, покрытую белым гипсом"), new XAttribute("answer", "Да")),
                new XElement("questions", new XAttribute("question", "На луну воют только волки-одиночки"), new XAttribute("answer", "Нет")),
                new XElement("questions", new XAttribute("question", "Бамбук самая высокая трава в мире."), new XAttribute("answer", "Да")),
                new XElement("questions", new XAttribute("question", "Авторучка была изобретена ещё в Древнем Египте?"), new XAttribute("answer", "Да")),
                new XElement("questions", new XAttribute("question", "Совы не могут вращать глазами?"), new XAttribute("answer", "Да")),
                new XElement("questions", new XAttribute("question", "Дети могут слышать более высокие звуки, чем взрослые?"), new XAttribute("answer", "Да")),
                new XElement("questions", new XAttribute("question", "Лось является разновидностью оленя?"), new XAttribute("answer", "Да")),
                new XElement("questions", new XAttribute("question", "Мойву эскимосы сушат и едят вместо хлеба?"), new XAttribute("answer", "Да")),
                new XElement("questions", new XAttribute("question", "Радугу можно увидеть и в полночь?"), new XAttribute("answer", "Да")),
                new XElement("questions", new XAttribute("question", "Утром вы выше ростом, чем вечером?"), new XAttribute("answer", "Да"))));
            xDoc.Save("questions.xml");
            //
        }

    }
    class XmlData
    {
        public string question { get; set; }
        public string answer { get; set; }
    }

}
    