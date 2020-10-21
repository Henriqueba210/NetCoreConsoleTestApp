namespace consoleTestApp
{
    public class Manager : Employee
    {
        public double raiseAmount { get; set; }

        public Manager(string name, string birthday, double salary, string address, double raiseAmount) : base(name, birthday, salary, address)
        {
            this.raiseAmount = raiseAmount;
        }

        public void raiseSalary() {
            this.salary = salary + (salary * raiseAmount / 100);
        }
    }
}