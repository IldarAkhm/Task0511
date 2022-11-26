using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0511_number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Boris = new Person("Борис");

            Person Marat = new Person("Ляйсан", "Марат", "Разработка");
            Person Dina = new Person("Ляйсан", "Дина", "Разработка");
            Person Ildar = new Person("Ляйсан", "Ильдар", "Разработка");
            Person Anton = new Person("Ляйсан", "Антон", "Разработка");

            Person Ilya = new Person("Иваныч", "Илья", "Разработка");
            Person Vitya = new Person("Иваныч", "Витя", "Систематизация");
            Person Jeka = new Person("Иваныч", "Жека", "Систематизация");

            Person Lyaisan = new Person("Сергей", "Ляйсан", "Разработка");
            Person Sergey = new Person("Володя", "Сергей", "Разработка");

            Person Volodya = new Person("Оркадий", "Володя", "Информационные системы");

            Person Orkadiy = new Person("О Ильхам", "Оркадий", "Информационные системы");

            Person OIlham = new Person("Борис", "О Ильхам", "Автоматизация");
            
            Person Ivanich = new Person("Ильшат", "Иваныч", "Разработка");
            Person Ilshat = new Person("Володя", "Ильшат", "Разработка");

            Person Rashid = new Person("Борис", "Рашид", "Бухгалтерия");

            Person Lukas = new Person("Рашид", "Лукас", "Финансы");


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

            



            Person.CheckChief(Rashid, Lukas, a, "авто");
            


            Console.Read();

        }
    }
}
