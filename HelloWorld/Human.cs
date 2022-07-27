using System;
namespace HelloWorld
{
    class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private sbyte age;

        public Human(string firstName, string lastName, string eyeColor, sbyte age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public int Height { get ; set; }

        public void IntroduceMyself()
        {
            string yearDeclaration = age > 1 ? "years" : "year";
            Console.WriteLine($"Hello my name is {firstName} {lastName} and I am {age} {yearDeclaration} old.");
        }
    }
}

