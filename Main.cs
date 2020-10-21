using System;
using System.Collections.Generic;

namespace consoleTestApp
{
    class main
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Henrique", "21/10/2001", 1500.00, "Rua Mississippi 74");
            var manager = new Manager("Rafa", "03/04/1997", 7000.00, "", 5.00);
            manager.raiseSalary();
            List<Employee> employeeList = new List<Employee>(new[] { employee, manager });
            Console.WriteLine($"Olá: {employee.name} você foi contratado em: {employee.hireDate.ToShortDateString()} e você tem: {employee.getAge()} anos");
            employeeList.ForEach(
                (employee) => Console.WriteLine($"Olá: {employee.name} seu salário é: {employee.salary}")
            );
        }
    }
}
