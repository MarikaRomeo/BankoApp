namespace BankoApp
{
    internal class Person
    {
        public string Name { get; set; }
        public string PersonalNumber { get; set; }
        public Person(string name, string personalNumber)
        {
            Name = name;
            PersonalNumber = personalNumber;
        }
    }
}
