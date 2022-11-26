using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBank
{
    enum Typee
    {
        Saved,
        Personal
    }
    class Bank
    {
        private Guid rootcheck;
        private double balanse = 100;
        private string typecheck = Convert.ToString(Typee.Personal);
        static Guid root = Guid.NewGuid();

        public Guid Root
        {
            get { return rootcheck; }
            set { rootcheck = value; }
        }

        public double Balanse
        {
            get { return balanse; }
            set { balanse = value; }
        }

        public string Type
        {
            get { return typecheck; }
            set { typecheck = value; }
        }

        public void TakeoffMoney(int a) //Снять деньги
        {
            if (a <= balanse)
            {
                balanse = balanse - a;
            }
            else
            {
                Console.WriteLine("Hедостаточно средств");
            }
        }
        public void CHeckMoney() // Проверка счета
        {
            Console.WriteLine($"{balanse}");
        }
        public virtual void Translate(Bank bank, double sum, Bank bank1) // Перевод
        {
            bank.balanse = balanse - sum;
        }
    }
    class Tinkof : Bank // Второй банк
    {
        private double balanse = 1000;

        public double Balanse
        {
            get { return balanse; }
            set { balanse = value; }
        }
        public override void Translate(Bank bank, double sum, Bank bank1)
        {
            base.Translate(bank, sum, bank1);
            balanse = balanse + sum;
        }


    }
    
}
