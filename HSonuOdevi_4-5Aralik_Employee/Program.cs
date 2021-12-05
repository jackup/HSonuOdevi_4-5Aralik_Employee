using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSonuOdevi_4_5Aralik_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee h1 = new HourlyEmployee(20, 40);
            h1.FirstName = "Fırat";
            h1.LastName = "Çakmak";
            h1.SSN = "15253545";
            Console.WriteLine(h1.ToString());
            Console.WriteLine();

            SalariedEmployee s1 = new SalariedEmployee(750);
            s1.FirstName = "Hacı";
            s1.LastName = "Bakar";
            s1.SSN = "10203040";
            Console.WriteLine(s1.ToString());
            Console.WriteLine();

            CommissionEmployee c1 = new CommissionEmployee(0.2, 2000);
            c1.FirstName = "Berke";
            c1.LastName = "Fakir";
            c1.SSN = "00001100";
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

            BasePlusCommissionEmployee b1 = new BasePlusCommissionEmployee(0.1, 1500, 1000);
            b1.FirstName = "Ogün";
            b1.LastName = "Zengin";
            b1.SSN = "11110011";
            Console.WriteLine(b1.ToString());
            Console.WriteLine();

        }
    }
}
