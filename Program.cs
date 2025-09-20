namespace BankoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bjornina", "19900101-1234");
            BankAccount bankAccount = new BankAccount(1000);
            Customer customer = new Customer(person, bankAccount);


            Console.WriteLine("Welcome to the BankoApp!");
            Console.Write("Please enter your PIN: ");
            string inputPin = Console.ReadLine();
            

            if (customer.ValidatePin(inputPin))
            {
                Console.WriteLine($"Welcome, {customer.Person.Name}!");
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. View Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Exit");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine($"Your balance is: {customer.Account.balance:N2} Kr");
                            break;
                        case "2":
                            Console.Write("Enter deposit amount: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            {
                                try
                                {
                                    customer.Account.Deposit(depositAmount);
                                    Console.WriteLine($"Deposited {depositAmount:N2} Kr. New balance is {customer.Account.balance:N2} Kr");
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                            break;
                        case "3":
                            Console.Write("Enter withdrawal amount: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                            {
                                try
                                {
                                    customer.Account.Withdraw(withdrawAmount);
                                    Console.WriteLine($"Withdrew {withdrawAmount:N2} Kr. New balance is {customer.Account.balance:N2} Kr");
                                }
                                catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                            break;
                        case "4":
                            exit = true;
                            Console.WriteLine("Thank you for using BankoApp. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN. Access denied.");
            }
        }
    }
}
