using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();

            Salesperson fran = new Salesperson("Fran", 43, 93, 3000, "932-23-2322", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.ReadLine();
        }
    }
}
