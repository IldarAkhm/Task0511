﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork;

namespace Task0511
{
    internal class Program
    {
        static void Otvet(Type a, Type b, Type c)
        {
            if (a.IsSubclassOf(b) && (a.IsSubclassOf(c) || c.IsSubclassOf(a))) { Console.WriteLine("Yes"); } // проверяем наследование
            else { Console.WriteLine("No"); }
        }
        static void Main(string[] args)
        {
            //Таблица с именами и должностями
            Console.WriteLine("Главный в конторе Boris – генеральный директор.\r\nУ Borisa есть подчиненные:\r\n·       Финансовый директор – Rashid,\r\n·       Директор по автоматизации – OIlham.\r\n\r\nРашид в подчинении держит бухгалтерию. В бухгалтерии главный Lukas.\r\n \r\nOIlham в подчинении держит отдел информационных технологий. В отделе информационных технологий следующая иерархия: существует начальник, зам. начальника и 2 сектора.\r\n·   \tНачальник инф систем – Orcadiy\r\n·   \tЗам.начальника – Volodya.\r\n·       системщики (занимаются сетями).\r\no   Главный в секторе системщиков: Ilshat,\r\no   Зам: Ivanich,\r\no   Сотрудники: Ilya, Vitya, Jeka\r\n·       разработчики (разработка и сопровождение).\r\no   Главный секторе разработчиков: Sergey,\r\no   Зам: Lyaisan,\r\no   Сотрудники: Marat, Dina , Ildar, Anton\r\n");

            Console.WriteLine("Виды работа:\n Finance - работа с финансами\n AutomatizationSystem - автоматизация систем\n InformationSystem - информационные системы\n " +
                "Systematization - Систематизация\n Develop - разработка\n\n ");
            Console.WriteLine("Введите от кого хотите дать задачу (на английском)");
            string A1 = Console.ReadLine();
            Console.WriteLine("Введите кому хотите дать задачу (на английском)");
            string B1 = Console.ReadLine();
            if (A1 == B1) { Console.WriteLine("Сам себе задание не даш"); }
            Console.WriteLine("Введите название задачи");
            string C1 = Console.ReadLine();
            Type A = Type.GetType("ClassWork" + "." + A1, false, true); // типы классов
            Type B = Type.GetType("ClassWork" + "." + B1, false, true);
            Type C = Type.GetType("ClassWork" + "." + C1, false, true);
            Console.WriteLine($"Итак, от {A1} дана задача {C1}  для {B1}.");
            Console.WriteLine("Ответ сотрудника:");
            Otvet(B, A, C);
            Console.Read();
            
        }
    }
}
