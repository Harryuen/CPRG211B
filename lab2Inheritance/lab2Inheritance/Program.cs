using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace lab2Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("employees.txt");

            List<Employee> employees = new List<Employee>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(':');

                string id = columns[0];
                string name = columns[1];
                string address = columns[2];
                string phone = columns[3];
                long sin = long.Parse(columns[4]);
                string dob = columns[5];
                string dept = columns[6];

                char firstDigitofId = id[0];
                if (firstDigitofId >= '0' && firstDigitofId <= '4')
                {
                    // Create a Salaried employee object
                    double salary = double.Parse(columns[7]); // Salary is in the 8th column
                    Salaried salariedEmployee = new Salaried(id, name, address, phone, sin, dob, dept, salary);
                    employees.Add(salariedEmployee);
                }
                else if (firstDigitofId >= '5' && firstDigitofId <= '7')
                {
                    // Create a Wage employee object
                    double hourlyRate = double.Parse(columns[7]); // Hourly rate is in the 8th column
                    int hoursWorked = int.Parse(columns[8]); // Hours worked is in the 9th column
                    Wage wageEmployee = new Wage(id, name, address, phone, sin, dob, dept, hourlyRate, hoursWorked);
                    employees.Add(wageEmployee);
                }
                else if (firstDigitofId >= '8' && firstDigitofId <= '9')
                {
                    // Create a PartTime employee object
                    double hourlyRate = double.Parse(columns[7]); // Hourly rate is in the 8th column
                    int hoursWorked = int.Parse(columns[8]); // Hours worked is in the 9th column
                    PartTime partTimeEmployee = new PartTime(id, name, address, phone, sin, dob, dept, hourlyRate, hoursWorked);
                    employees.Add(partTimeEmployee);
                }

            }


            // Calculate and return the average weekly pay for all employees.

            Console.WriteLine("\nb.\tCalculate and return the average weekly pay for all employees.");
            double totalWeeklyPay = 0.0;

            foreach (var employee in employees)
            {
                totalWeeklyPay += employee.GetPay();
            }

            double averageWeeklyPay = totalWeeklyPay / employees.Count;

            Console.WriteLine($"\tAverage Weekly Pay for All Employees: {averageWeeklyPay:C}");



            //Calculate and return the highest weekly pay for the wage employees, including the name of the employee.
            Console.WriteLine("\nc.\tCalculate and return the highest weekly pay for the wage employees, including the name of the employee.");
            double highestWeeklyPay = 0.0;
            string employeeWithHighestPay = "";

            foreach (var employee in employees)
            {
                if (employee is Wage wageEmployee)
                {
                    double weeklyPay = wageEmployee.GetPay();
                    if (weeklyPay > highestWeeklyPay)
                    {
                        highestWeeklyPay = weeklyPay;
                        employeeWithHighestPay = employee.Name;
                    }
                }
            }

            if (!string.IsNullOrEmpty(employeeWithHighestPay))
            {
                Console.WriteLine($"\tEmployee with the Highest Weekly Pay: {employeeWithHighestPay} (${highestWeeklyPay:C})");
            }
            else
            {
                Console.WriteLine("\tNo Wage employees found.");
            }


            //Calculate and return the lowest salary for the salaried employees, including the name of the employee.
            Console.WriteLine("\nd.\tCalculate and return the lowest salary for the salaried employees, including the name of the employee.");
            double lowestSalary = double.MaxValue;
            string employeeWithLowestSalary = "";

            foreach (var employee in employees)
            {
                if (employee is Salaried salariedEmployee)
                {
                    double SalaryPay = salariedEmployee.GetPay();
                    if (SalaryPay < lowestSalary)
                    {
                        lowestSalary = SalaryPay;
                        employeeWithLowestSalary = employee.Name;
                    }
                }
            }

            if (!string.IsNullOrEmpty(employeeWithLowestSalary))
            {
                Console.WriteLine($"\tEmployee with the Lowest Salary: {employeeWithLowestSalary} (${lowestSalary * 52:C})");
            }
            else
            {
                Console.WriteLine("\tNo salaried employees found.");
            }


            //What percentage of the company’s employees fall into each employee category?
            Console.WriteLine("\ne.\tWhat percentage of the company’s employees fall into each employee category?");
            int totalEmployees = employees.Count;
            int salariedEmployeesCount = employees.Count(e => e is Salaried);
            int wageEmployeesCount = employees.Count(e => e is Wage);
            int partTimeEmployeesCount = employees.Count(e => e is PartTime);

            double salariedPercentage = (double)salariedEmployeesCount / totalEmployees * 100.0;
            double wagePercentage = (double)wageEmployeesCount / totalEmployees * 100.0;
            double partTimePercentage = (double)partTimeEmployeesCount / totalEmployees * 100.0;

            Console.WriteLine($"\tPercentage of Salaried Employees: {salariedPercentage:F2}%");
            Console.WriteLine($"\tPercentage of Wage Employees: {wagePercentage:F2}%");
            Console.WriteLine($"\tPercentage of PartTime Employees: {partTimePercentage:F2}%");


        }



    }
}