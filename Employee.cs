using System;
using System.Globalization;

namespace consoleTestApp
{
    public class Employee
    {
        public string name { get; set; }
        private int age { get; set; }
        public string address { get; set; }
        public DateTime hireDate { get; set; }
        public Double salary { get; set; }

        public Employee(String name, string dayOfBirth, Double salary, String address)
        {
            this.name = name;
            setAge(dayOfBirth);
            this.address = address;
            this.salary = salary;
            this.hireDate = DateTime.Today;
        }
        public Employee(String name, string dayOfBirth, String address, Double salary, String hireDate)
        {
            this.name = name;
            setAge(dayOfBirth);
            this.address = address;
            this.salary = salary;
            this.hireDate = DateTime.ParseExact(hireDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public int getAge() => this.age;
        public void setAge(string dayOfBirth) => age = (int)Math.Floor((DateTime.Today - DateTime.ParseExact(dayOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture)).TotalDays / 365);
    }
}