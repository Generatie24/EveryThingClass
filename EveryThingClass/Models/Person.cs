namespace EveryThingClass.Models
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public int Age;

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            Address = "1234 Main St";
            Age = 20;
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = 30;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Address} {Age}";
        }

        
    }
}
