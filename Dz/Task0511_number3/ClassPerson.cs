using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0511_number3
{
    internal class Person
    {
        public string chiefname { get; set; } = "Борис";
        public string employname { get; set; }
        public string work { get; set; }
        public Person(string chiefname, string employname, string work)
        {
            this.chiefname = chiefname;
            this.employname = employname;
            this.work = work;
        }

        public Person(string employname)
        {
            this.employname = employname;
        }
        

        public static void CheckCheck(Person name, Person employ, List<Person> a)
        {
            string chief = employ.chiefname;
            string chief1 = employ.chiefname;
            bool Flag = false;
            for (int i = 0; i < a.Count; i++)
            {
                for (int q = i; q < a.Count; q++)
                {
                    if (a[q].employname == chief)
                    {
                        chief = a[i].chiefname;
                        if (name.employname == chief1)
                        {
                            Console.WriteLine("Да");
                            Flag = true;    
                            break;
                        }
                    }
                    else
                    {                       
                        Flag = false;
                        continue;
                    }
                }
                if (Flag == true)
                {
                    break;
                }
            }
            if (Flag == false)
            {
                Console.WriteLine("Нет");
            }
        }
        public static void CheckChief(Person name, Person employ, List<Person> a, string q)
        {
            if (name.employname == employ.employname)
            {
                Console.WriteLine("Сам себе задание не задашь!");
            }
            else if (q != employ.work)
            {
                Console.WriteLine("Такую работу не делаем");
            }
            else if (name.employname == employ.chiefname)
            {
                Console.WriteLine("Да");
            }
            else if (employ.employname == "Борис")
            {
                Console.WriteLine("На власть не лезут.");
            }
            else
            {
                Person.CheckCheck(name, employ, a);
            }
        }

    }
}
