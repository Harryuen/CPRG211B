using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Inheritance
{
    internal class Employee
    {

        private string id = "";
        private string name = "";
        private string address = "";
        private string phone = "";
        private long sin;
        private string dob = "";
        private string dept = "";

        public string Id { get => id; set => id = value;}
        public string Name { get => name; set => name = value;}
        public string Address{get => address; set => address = value;}
        public string Phone{get => phone; set => phone = value;}
        public long Sin{get => sin; set => sin = value;}
        public string Dob{get => dob; set => dob = value;}
        public string Dept{get => dept; set => dept = value;}

        public Employee()
        {

            id = "";
            name = "";
            address = "";
            phone = "";
            sin = 0;
            dob = "";
            dept = "";
        }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
        }

        //Method

        public virtual double GetPay()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return this.Name;

        }
    }
}
