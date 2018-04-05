namespace VisitorPattern {
    public class Loan : IAsset {
        public int Owed { get; set; }
        public int MonthlyRent { get; set; }

        public Loan(int owed, int monthlyRent) {
            Owed = owed;
            MonthlyRent = monthlyRent;
        }
        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
}