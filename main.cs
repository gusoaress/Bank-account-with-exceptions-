using System;
using BankAcc.Entities;
using BankAcc.Entities.Exceptions;

class Program 
{
  public static void Main (string[] args) 
  {
    
    Console.Write("Account Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Enter the Holders name: ");
    string name = Console.ReadLine();
    Console.Write("Enter the inicial Balance of your account: "); 
    double balance = double.Parse(Console.ReadLine());
    Console.Write("Enter with your withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine()); 

    Account acc = new Account(number, name, balance, withdrawLimit);

    Console.WriteLine( );
    Console.WriteLine("Enter a amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine());
    try 
    {
      acc.WithDraw(amount);
      Console.WriteLine($"New balance: {acc.Balance.ToString("F2")}"); 
    }
    catch (DomainException e) 
    {
        Console.WriteLine($"Withdraw error: {e.Message}"); 
    }
        
    Console.WriteLine(acc); 
      
      
  }
}