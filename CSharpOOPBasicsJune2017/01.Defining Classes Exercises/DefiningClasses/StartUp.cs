using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var accounts = new Dictionary<int, BankAccount>();
        var input = Console.ReadLine();

        while (input!="End")
        {
            var inputArgs = input.Split();

            switch (inputArgs[0])
            {
                case "Create":
                    Create(inputArgs, accounts);
                    break;
                case "Deposit":
                    Deposit(inputArgs, accounts);
                    break;
                case "Withdraw":
                    Withdraw(inputArgs, accounts);                    
                    break;
                case "Print":
                    Print(inputArgs, accounts);
                    break;
              
            }

            input = Console.ReadLine();
        }
    }

    private static void Print(string[] inputArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(inputArgs[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }

        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] inputArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(inputArgs[1]);
        var amount = double.Parse(inputArgs[2]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }

        else
        {
            if (accounts[id].Balance<amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
            
        }
    }

    private static void Deposit(string[] inputArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(inputArgs[1]);
        var amount = double.Parse(inputArgs[2]);

        if (!accounts.ContainsKey(id))
        { 
            Console.WriteLine("Account does not exist");
        }

        else
        {
            accounts[id].Deposit(amount);
        }
    }

    private static void Create(string[] inputArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(inputArgs[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id,acc);
        }
    }
}

