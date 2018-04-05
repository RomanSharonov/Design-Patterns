namespace VisitorPattern {

    public class RealEstate : IAsset {
        public int EstimatedValue { get; set; }
        public int MonthlyRent { get; set; }

        public RealEstate(int estimatedValue, int monthlyRent) {
            EstimatedValue = estimatedValue;
            MonthlyRent = monthlyRent;
        }

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
}