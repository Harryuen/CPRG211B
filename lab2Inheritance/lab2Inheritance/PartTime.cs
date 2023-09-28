using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Inheritance
{
    internal class PartTime : Employee
    {
        // Properties specific to PartTime employees
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTime() { }

        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double hourlyRate, int hoursWorked)
            : base(id, name, address, phone, sin, dob, dept)
        {
            this.HourlyRate = hourlyRate;
            this.HoursWorked = hoursWorked;
        }

        // Method to calculate PartTime employee's weekly pay
        public override double GetPay()
        {
            // Calculate the weekly pay for PartTime employees
            double weeklyPay = HourlyRate * HoursWorked;
            return weeklyPay;
        }

        public override string ToString()
        {
            return base.ToString() + " (PartTime)";
        }
    }
}
