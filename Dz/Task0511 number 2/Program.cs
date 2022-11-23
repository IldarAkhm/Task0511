using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0511_number_2
{
    class Chief  { }
    class ChiefEmployee : Chief {}
    class ChiefKeefEmployee : ChiefEmployee { }
    class SuperChiefKeefEmployee : ChiefKeefEmployee { }
    class Employee : SuperChiefKeefEmployee { }
    internal class Program
    {
        static void Otvet(Type a, Type b)
        {
            if (a.IsSubclassOf(b)) { Console.WriteLine("Yes"); } // проверяем наследование
            else { Console.WriteLine("No"); }
        }
        static void Main(string[] args)
        {
            Chief Boris = new Chief();
            


            Console.Read();
        }
    }
}
