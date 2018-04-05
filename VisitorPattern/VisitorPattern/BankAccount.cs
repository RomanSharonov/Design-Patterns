namespace VisitorPattern {
    public class BankAccount : IAsset {
        public int Amount { get; set; }
        public double MonthlyInterest { get; set; }

        public BankAccount(int amount, double monthlyInterest) {
            Amount = amount;
            MonthlyInterest = monthlyInterest;
        }  

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
}