using System;
using Xunit;

namespace consoleTestApp.Tests
{
    public class PersonTest
    {
        [Fact]
        public void calculatedAgeIsCorrect()
        {
            var Person1 = new Person("22/10/2020");
            var Person2 = new Person("22/10/2019");
            var Person3 = new Person("22/10/2000");
            var Person4 = new Person("23/10/2020");
            var Person5 = new Person("23/10/2019");
            var Person6 = new Person("23/10/2000");
            var Person7 = new Person("23/10/2021");
            var Person8 = new Person("24/10/2020");
            var Person9 = new Person("24/10/2019");
            var Person10 = new Person("24/10/2000");

            var henrique = new Person("21/10/2001");

            var anoBissexto = new Person("29/02/2016");

            Assert.Equal(0, Person1.getAge());
            Assert.Equal(1, Person2.getAge());
            Assert.Equal(20, Person3.getAge());
            Assert.Equal(0, Person4.getAge());
            Assert.Equal(1, Person5.getAge());
            Assert.Equal(20, Person6.getAge());
            Assert.Equal(0, Person7.getAge());
            Assert.Equal(0, Person8.getAge());
            Assert.Equal(1, Person9.getAge());
            Assert.Equal(20, Person10.getAge());

            Assert.Equal(19, henrique.getAge());
            Assert.Equal(4, anoBissexto.getAge());
        }
    }
}
