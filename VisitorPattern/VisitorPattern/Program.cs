using System;

namespace VisitorPattern {
    class Program {
        static void Main(string[] args) {

            var person = new Person();
            person.Assets.Add(new BankAccount(amount: 1000, monthlyInterest: 0.01));
            person.Assets.Add(new BankAccount(amount: 2000, monthlyInterest: 0.02));
            person.Assets.Add(new RealEstate(estimatedValue: 79000, monthlyRent: 500));
            person.Assets.Add(new Loan(owed: 40000, monthlyRent: 40));

            var netWorth = new NetWorthVisitor();
            person.Accept(netWorth);

            Console.WriteLine(netWorth.Total);
            Console.ReadKey();
        }
    }
}
