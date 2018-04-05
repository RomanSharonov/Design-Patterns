namespace VisitorPattern {
    public interface IAsset {
        void Accept(IVisitor visitor);
    }
}