using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Inheritance
{
    internal class Salaried : Employee
    {
        private double salary;

        public double Salary { get; set; }

        public Salaried() { }

        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Salary = salary;
        }
        public override double GetPay()
        {
            // Calculate the weekly pay by dividing the annual salary by 52 weeks
            return Salary / 52;
        }
    }
}
