using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new();
            try
            {
                account.Deposit(1000m);
                account.Withdraw(50m);
            } catch(Exception e) 
            {
                if (e is NegativeAmountException || e is InsufficientAmountException)
                {
                    Console.WriteLine(e.Message);
                }
            }
            finally
            {
                Console.WriteLine($"Account: { account.Balance }");
            }
        }
    }
}