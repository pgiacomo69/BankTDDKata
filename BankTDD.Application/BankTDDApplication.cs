using BankTDD.Model;

namespace BankTDD.Application;

public class BankTDDApplication<TRepository> where TRepository: IBankTDDRepository
{
    private IBankTDDRepository Repository;
    
}