using System;
using System.Collections.Generic;
using System.Text;

namespace trylab4._1
{
    class Consoleee
    {
        public bool Menu()
        {
            bool showMenu = true;
            while (showMenu == true)
            {
                showMenu = MainMenu();
            }
            return true;
        }

        public bool MainMenu()
        {
            Payment entity = new Payment(" ", " ", 0, 0);

            string a;
            Console.WriteLine("Enter member`s name: ");
            a = Console.ReadLine();
            entity.SetName(a);

            string b;
            Console.WriteLine("Enter member`s surname: ");
            b = Console.ReadLine();
            entity.SetSurname(b);

            double c;
            Console.WriteLine("Enter sum to pay: ");
            c = Convert.ToDouble(Console.ReadLine());
            entity.SetSum(c);

            double d;
            Console.WriteLine("Enter the paid amount: ");
            d = Convert.ToDouble(Console.ReadLine());
            entity.SetPaid(d);

            double e = 0;
            entity.SetRemainder(c,d,e);

            bool f = false;
            entity.Is_Correct(f);

            bool g = false;
            entity.Paid_More(g);

            Console.WriteLine(entity);
            return true;
        }
    }
}
