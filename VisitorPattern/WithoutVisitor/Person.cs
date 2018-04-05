using System.Collections.Generic;

namespace WithoutVisitor {
    internal class Person {
        public List<BankAccount> BankAccounts = new List<BankAccount>();
        public List<RealEstate> RealEstates = new List<RealEstate>();
        public List<Loan> Loans = new List<Loan>();}
}