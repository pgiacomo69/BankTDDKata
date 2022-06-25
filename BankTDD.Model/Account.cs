namespace BankTDD.Model;

public class Account
{
    public int Balance { get; private set; }

    public Account(int initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(int amount)
    {
        Balance -= amount;
    }

    public void Withdraw(int amount)
    {
        Balance -= amount;
    }
}