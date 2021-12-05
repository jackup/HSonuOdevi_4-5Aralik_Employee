using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSonuOdevi_4_5Aralik_Employee
{
    public class SalariedEmployee : Employee
    {
        private double weeklySalary;

        public double WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        public SalariedEmployee(double _weeklySalary)
        {
            weeklySalary = _weeklySalary;
        }

        public override double Earnings()
        {
            return weeklySalary;
        }

        public override string ToString()
        {
            return string.Format("Salaried Employee : " + FirstName + " " + LastName + "\nSocial Security Number : " + SSN +
                "\nWeekly Salary : " + WeeklySalary + "\nTotal Earnings : " + Earnings());
        }
    }
}
