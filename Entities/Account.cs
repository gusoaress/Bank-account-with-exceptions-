namespace BankAccount.Entities
{
  class Account
  {
    public int Number {get; set;}
    public string Holder {get; set;}
    public double Balance {get; set;}
    public double WithdrawLimit {get; set;}

    public Account () {}
    public Account (int number, string holder, double balance, double withdrawLimit)
    {
      Number = number; 
      Holder = holder;
      Balance = balance;
      WithdrawLimit = withdrawLimit;
    }

    
  
  }
}