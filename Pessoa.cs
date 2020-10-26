using System;
using System.Globalization;

namespace consoleTestApp
{
    public class Person
    {
        private int Age { get; set; }

        public Person(string birthday)
        {
            setAge(birthday);
        }

        public int getAge() => Age;
        public void setAge(string dayOfBirth)
        {
            var today = DateTime.Today;
            var birthday = DateTime.ParseExact(dayOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (birthday >= today)
            {
                Age = 0;
            }
            else
            {
                Age = today.Year - birthday.Year;

                if (birthday.AddYears(Age) > today)
                    Age--;
            }
        }
    }
}
