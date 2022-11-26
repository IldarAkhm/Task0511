using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task0511_number4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Boris = new Person("Борис");
            Person Rashid = new Person(Boris, "Рашид", "Бухгалтерия");
            Person OIlham = new Person(Boris, "О Ильхам", "Автоматизация");
            Person Lukas = new Person(Rashid, "Лукас", "Финансы");
            Person Orkadiy = new Person(OIlham, "Оркадий", "Информационные системы");
            Person Volodya = new Person(Orkadiy, "Володя", "Информационные системы");
            Person Sergey = new Person(Volodya, "Сергей", "Разработка");
            Person Ilshat = new Person(Volodya, "Ильшат", "Систематизация");
            Person Lyaisan = new Person(Sergey, "Ляйсан", "Разработка");
            Person Ivanich = new Person(Ilshat, "Иваныч", "Систематизация");

            Person Marat = new Person(Lyaisan, "Марат", "Разработка");

            Person Dina = new Person(Lyaisan, "Дина", "Разработка");
            Person Ildar = new Person(Lyaisan, "Ильдар", "Разработка");
            Person Anton = new Person(Lyaisan, "Антон", "Разработка");

            Person Ilya = new Person(Ilshat, "Илья", "Разработка");
            Person Vitya = new Person(Ilshat, "Витя", "Систематизация");
            Person Jeka = new Person(Ilshat, "Жека", "Систематизация");

            List<Person> a = new List<Person>();
            a.Add(Marat); a.Add(Dina);
            a.Add(Ildar); a.Add(Anton);

            a.Add(Ilya); a.Add(Vitya);
            a.Add(Jeka);

            a.Add(Lukas);

            a.Add(Lyaisan); a.Add(Ivanich);

            a.Add(Sergey); a.Add(Ilshat);

            a.Add(Volodya); a.Add(Orkadiy);

            a.Add(Rashid); a.Add(OIlham);

            a.Add(Boris);

            Person.CheckChief(Rashid, Lukas, a, "Финансы");



            Console.Read();
        }
    }
}
