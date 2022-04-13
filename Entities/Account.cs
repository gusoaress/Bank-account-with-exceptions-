using BankAcc.Entities.Exceptions;

namespace BankAcc.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account () {}
        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("You can't Withdraw more than you withdraw limit");
            }
            if (amount > Balance)
                throw new DomainException("You don't have enogh money in your account");
            Balance -= amount;
        }

        public override string ToString()
        {
            return "Number Account: " + Number
            + " Holder: " + Holder
            + " Initial Balance: " + Balance
            + " Withdraw limit: " + WithdrawLimit;
        }
    }
}