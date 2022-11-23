using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task0511_number2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<List<string>> hierachy = new List<List<string>>(); // Список с иерархиями
            List<List<string>> tasks = new List<List<string>>(); // Список с задачами
            List<string> Boris = new List<string>() { "Boris" }; // Дальше списки с подчиненными для каждого человека, 0 индекс сам начальник
            List<string> Rashid = new List<string>() { "Finance", "Rashid", "Lukas" };
            List<string> OIlham = new List<string>() { "Automatization", "OIlham" };
            List<string> Orcadiy = new List<string>() { "InformationSystem", "Orcadiy" };
            List<string> Volodya = new List<string>() { "Volodya" };
            List<string> Ilshat = new List<string>() { "Systematization", "Ilshat" };
            List<string> Ivanich = new List<string>() { "Ivanich", "Ilya", "Vitya", "Jeka" };

            List<string> sergey = new List<string>() { "Develop", "Sergey" };
            List<string> lyaisan = new List<string>() { "Lyaisan", "Marat", "Dina", "Ildar", "Anton" };

            List<string> employerslosers = new List<string>() { "Marat", "Dina", "Ildar", "Anton", "Ilya", "Vitya", "Jeka" }; // Список тех, кто не может давать задачи

            
            sergey.AddRange(lyaisan); // Для облегчения жизни добавляем к начальству рабочих через AddRange
            Ilshat.AddRange(Ivanich);
            Volodya.AddRange(Ilshat); Volodya.AddRange(sergey);
            Orcadiy.AddRange(Volodya);
            OIlham.AddRange(Orcadiy);
            Boris.AddRange(OIlham); Boris.AddRange(Rashid);

            hierachy.Add(lyaisan); hierachy.Add(sergey); hierachy.Add(Ivanich); // Теперь все списки добавляем в иерархию
            hierachy.Add(Ilshat); hierachy.Add(Volodya); hierachy.Add(Orcadiy);
            hierachy.Add(OIlham); hierachy.Add(Rashid); hierachy.Add(Boris);

            tasks.Add(Rashid); tasks.Add(OIlham); tasks.Add(Ilshat);
            tasks.Add(sergey); tasks.Add(Orcadiy);

            CheckList(tasks);
            Employee.CheckTask(employerslosers, Boris, hierachy, tasks);




            Console.Read();
        }
        public static void CheckList(List<string> a) // Метод для проверки массива
        {
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
        public static void CheckList(List<List<string>> a) // Метод для проверки массива
        {
            foreach (var i in a)
            {
                foreach (var q in i)
                {
                    Console.WriteLine(q);
                }
                Console.Write("\n");
            }
        }
    }
}
