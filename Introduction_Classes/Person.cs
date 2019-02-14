using System;

namespace Introduction_Classes
{
    public class Person
    {
        public string Name { get; set; }


        public  void Introduce(string to)
        {
            Console.WriteLine(" Hi {0} , I am {1}",to,Name);
        }

        public Person  Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
        //static method
        public static  Person ParseSt(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }

    }
}
