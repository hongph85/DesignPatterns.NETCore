namespace DesignPatterns.NETCore.Behaviors.Iterator
{
    class Person
    {
        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
