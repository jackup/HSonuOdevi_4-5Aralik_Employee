using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSonuOdevi_4_5Aralik_Employee
{
    public class HourlyEmployee : Employee
    {
        private double wage;

        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }

        private double hours;

        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public HourlyEmployee(double _wage, double _hours)
        {
            wage = _wage;
            hours = _hours;
        }

        public override double Earnings()
        {
            if (hours <= 40)
            {
                return wage * hours;
            }
            else
            {
                return (40 * wage) + ((hours - 40) * wage * 1.5);
            }
        }
        public override string ToString()
        {
            return string.Format("Hourly Employee : " + FirstName + "\t" + LastName + "\nSocial Security Number : " + SSN + 
                "\nHourly Wage : " + Wage + "\nHours Worked : " + Hours + "\nTotal Earnings : " + Earnings());
        }
    }
}
