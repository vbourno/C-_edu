using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        public long Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set;}
        public int? Ssn { get; set; }
        public decimal? Balance { get; set; }

        // API

        /// <summary>
        /// Deposits a certain amount of money.
        /// </summary>
        /// <param name="amount">The amount of money.</param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount > 0)
                {
                    Balance += amount;
                }
                else
                {
                    throw new NegativeAmountException("Negative Amount");
                }
            } catch (NegativeAmountException e) 
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        public void Withdraw (decimal amount) 
        {
            try
            {
                if (amount > Balance) 
                {
                    throw new InsufficientAmountException("Insufficient Amount");
                }
                else
                {
                    Balance -= amount;
                }

            } catch (InsufficientAmountException e) 
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        public override string ToString()
        {
            return $"Iban: {Iban}";
        }
    }
}
