using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    string accountHolderName;
    double initialBalance;
    public BankAccount(string name, double balance)
    {
        accountHolderName = name;
        initialBalance = balance;
    }
    public void Deposit(double amount)
    {
        initialBalance += amount;
    }
    public void Deposit(string checkNumber, double amount)
    {
        initialBalance += amount;
    }
    public void Withdraw(double amount)
    {
        if (amount <= initialBalance)
        {
            initialBalance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    public void Withdraw(string checkNumber, double amount)
    {
        if (amount <= initialBalance)
        {
            initialBalance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }
    public void ShowBalance()
    {
        Console.WriteLine("Current Balance: " + initialBalance);
    }
}