using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Inheritance
{
    internal class Wage : Employee
    {
        // Properties specific to Wage employees
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Wage() { }

        public Wage(string id, string name, string address, string phone, long sin, string dob, string dept, double hourlyRate, int hoursWorked)
            : base(id, name, address, phone, sin, dob, dept)
        {
            this.HourlyRate = hourlyRate;
            this.HoursWorked = hoursWorked;
        }

        // Method to calculate Wage employee's weekly pay
        public override double GetPay()
        {
            // Calculate the weekly pay for Wage employees with overtime
            if (HoursWorked > 40)
            {
                double regularPay = 40 * HourlyRate;
                double overtimePay = (HoursWorked - 40) * (HourlyRate * 1.5);
                return regularPay + overtimePay;
            }
            else
            {
                // No overtime, regular pay
                return HourlyRate * HoursWorked;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " (Wage)";
        }
    }
}
