﻿using System; 

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
            }
        }
    }
}