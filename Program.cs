using System; 

namespace BankAccountManager 
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            bool running = true;
            
            while (running)
            {
                Console.WriteLine("Welcome to the simple Bank Account Manager!");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice) 
                {
                    case "1":
                        Console.Write("Enter your name: ");
                        string name = Console.ReadLine();
                        account.CreateAccount(name);
                        Console.WriteLine($"Account created for {name}.");
                        break;
                    case "2": 
                        Console.Write("Enter amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.Deposit(depositAmount);
                            Console.WriteLine($"Deposited {depositAmount:C}.");
                        }
                        else 
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "3":
                            Console.Write("Enter amount to withdraw: ");
                            if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                            {
                                if (account.Withdraw(withdrawAmount))
                                {
                                    Console.WriteLine($"Withdrew {withdrawAmount:C}.");
                                }
                                else 
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                            }
                            else 
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                            break;
                    case "4": 
                        Console.WriteLine($"Your balance is {account.GetBalance():C}.");
                        break;
                    case "5": 
                        running = false;
                        Console.WriteLine("Thank you for using the Bank Account Manager. Goodbye!"); 
                        break;
                    default: 
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

public class BankAccount
{
    private string _name;
    private double _balance;

    public void CreateAccount(string name)
    {
        _name = name;
        _balance = 0;
    }
}