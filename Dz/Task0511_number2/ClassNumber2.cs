using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0511_number2
{
    class Employee : Program
    {
        
        public Employee Chief { get; set; }
        public string Employeer { get; set; }

        public static void CheckTask(List<string> lozers/*не имеют подчиненных*/, List<string> b/*все работники*/, List<List<string>> q/*иерархия*/, List<List<string>> t/*виды работа*/)
        { 
            Console.WriteLine("Введите имя первого человека: "); string chief = Console.ReadLine();
            Console.WriteLine("Введите имя второго человека: "); string employeer = Console.ReadLine();
            Console.WriteLine("Введите задачу: "); string task = Console.ReadLine();
            if (lozers.Contains(chief))
            {
                Console.WriteLine("No");
            }
            else if (b.Contains(chief) == false || b.Contains(employeer) == false) { Console.WriteLine("Таких нет"); }
            else if (chief == employeer) { Console.WriteLine("Сам себе задание не дашь"); }
            else if (String.IsNullOrEmpty(task) == true)
            {
                bool Flag = true;
                foreach (var i in q)
                {
                    if (i[0] == chief && i.Contains(employeer)) { Console.WriteLine("Yees"); Flag = false; }
                    else { continue; }
                }
                if (Flag == true) { Console.WriteLine("No"); }
            }
            else
            {
                bool Flag = true;
                foreach (var i in q)
                {
                    if (i[0] == chief && i.Contains(employeer)) 
                    { 
                        foreach (var r in t)
                        {
                            if (r.Contains(employeer) && r.Contains(task)) { Console.WriteLine("Ys"); Flag = false; break; }         
                            else { continue; }
                        }
                    }
                    else { continue; }
                }
                if (Flag == true) { Console.WriteLine("No"); }
            }
            
        }
     
        public Employee(Employee chief, string employeer)
        {
            this.Chief = chief;
            this.Employeer = employeer;
        }
        public Employee() { }
    }
}

