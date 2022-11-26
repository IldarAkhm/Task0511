using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0511_number4
{
    internal class Person
    {
        public Person chief { get; set; }
        public string employ { get; set; }
        public string work { get; set; }
        public Person(Person chief, string employ, string work)
        {
            this.chief = chief;
            this.employ = employ;
            this.work = work;
        }
        public Person(string employ) { this.employ = employ; }
        public Person() { }

        public static void CheckCheck(Person name, Person employ, List<Person> a)
        {
            Person chief = employ.chief;
            Person chief1 = employ.chief;
            bool Flag = false;
            for (int i = 0; i < a.Count; i++)
            {
                for (int q = i; q < a.Count; q++)
                {
                    if (a[q].chief == chief)
                    {
                        chief = a[i].chief;
                        if (name == chief1)
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
        public static void CheckChief(Person chief, Person employ, List<Person> a, string q)
        {
            if (chief.employ == employ.employ)
            {
                Console.WriteLine("Сам себе задание не задашь!");
            }
            else if (q != employ.work)
            {
                Console.WriteLine("Такую работу не делаем");
            }
            else if (chief == employ.chief)
            {
                Console.WriteLine("Да");
            }
            else if (employ.employ == "Борис")
            {
                Console.WriteLine("На власть не лезут.");
            }
            else
            {
                Person.CheckCheck(chief, employ, a);
            }
        }

    }
}
