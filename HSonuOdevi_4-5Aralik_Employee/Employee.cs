using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSonuOdevi_4_5Aralik_Employee
{
    public abstract class Employee
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string ssn;

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public abstract double Earnings();

        public override string ToString()
        {
            return string.Format(FirstName + "\t" + LastName + "\nSocial Security Number : " + SSN);
        }
    }
}
