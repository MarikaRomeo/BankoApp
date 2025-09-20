namespace BankoApp
{
    internal class Customer
    {
        private readonly string pin = "1234";
        public Person Person { get; set; }
        public BankAccount Account { get; set; }
        public Customer(Person person,BankAccount bankAccount) 
        { 
            Person = person;
            Account = bankAccount;
        }
        public bool ValidatePin(string inputPin)
        {
            return inputPin == pin;
        }
    }
}
