using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSonuOdevi_4_5Aralik_Employee
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double baseSalary;

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public BasePlusCommissionEmployee(double _commissionRate, double _grossSales, double _baseSalary) : base(_commissionRate, _grossSales)
        {
            CommissionRate = _commissionRate;
            GrossSales = _grossSales;
            baseSalary = _baseSalary;
        }

        public override double Earnings()
        {
            return base.Earnings() + BaseSalary;
        }

        public override string ToString()
        {
            return string.Format("Base Salaried Commission Employee : " + FirstName + " " + LastName + 
                "\nSocial Security Number : " + SSN +
                "\nGross Sales : " + GrossSales + "\nCommission Rate : " + CommissionRate + 
                "\nBase Salary : " + BaseSalary + "\nTotal Earnings : " + Earnings());
        }
    }
}
