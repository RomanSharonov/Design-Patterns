using System;

namespace WithoutVisitor {
    class Program
    {
        static void Main(string[] args) {
            var person = new Person();
            person.BankAccounts.Add(new BankAccount {Amount = 1000, MonthlyInterest = 0.01});
            person.BankAccounts.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.RealEstates.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500});
            person.Loans.Add(new Loan {Owed = 40000, MonthlyRent = 40});

            int netWorth = 0;
            foreach (BankAccount bankAccount in person.BankAccounts) {
                netWorth += bankAccount.Amount;
            }

            foreach (RealEstate realEstate in person.RealEstates) {
                netWorth += realEstate.EstimatedValue;            
            }

            foreach (Loan loan in person.Loans) {
                netWorth -= loan.Owed;
            }
            
            Console.WriteLine(netWorth);
            Console.ReadKey();
        }
    }
}
