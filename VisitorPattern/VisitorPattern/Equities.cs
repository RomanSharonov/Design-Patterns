using System.Data;

namespace VisitorPattern {
    public class Equities : IAsset {
        public string Id { get; set; }
        public int Amount { get; set; }

        public Equities(string id, int amount) {
            Id = id;
            Amount = amount;
        }

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
}