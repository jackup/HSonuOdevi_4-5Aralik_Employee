using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSonuOdevi_4_5Aralik_Employee
{
    public class CommissionEmployee : Employee
    {
        private double grossSales;

        public double GrossSales
        {
            get { return grossSales; }
            set { grossSales = value; }
        }
        private double commissionRate;

        public double CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }

        public CommissionEmployee(double _commissionRate, double _grossSales)
        {            
            commissionRate = _commissionRate;
            grossSales = _grossSales;
        }

        public override double Earnings()
        {
            return commissionRate * grossSales;
        }

        public override string ToString()
        {
            return string.Format("Commission Employee : " + FirstName + " " + LastName + "\nSocial Security Number : " + SSN +
                "\nGross Sales : " + GrossSales + "\nCommission Rate : " + CommissionRate + "\nTotal Earnings : " + Earnings());
        }
    }
}
