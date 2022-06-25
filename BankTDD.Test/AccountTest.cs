using BankTDD.Model;

namespace BankTDD.Test;

public class AccountTest
{
    [Theory]
    [InlineData (10)]
    public void Test_Account_InitBalanceShoultBeAccounted(int expectedBalance)
    {
        var account = new Account(expectedBalance);
        Assert.Equal(account.Balance,expectedBalance);
    }

    [Theory]
    [InlineData(10,1,11)]
    [InlineData(-10,11,1)]
    public void Test_Account_DepositShouldBeAccounted(int initialBalance, int depositAmout, int expectedBalance)
    {
        var account = new Account(initialBalance);
        account.Deposit(depositAmout);
        Assert.Equal(expectedBalance,account.Balance);
    }

    [Theory]
    [InlineData(10, 4, 6)]
    [InlineData(10, 13, -3)]
    public void Test_Account_WithdrawalShouldBeAccounted(int initialBalance, int withdrawalAmount, int expectedBalance)
    {
        var account = new Account(initialBalance);
        account.Withdraw(withdrawalAmount);
        Assert.Equal(account.Balance,expectedBalance);
    }
}