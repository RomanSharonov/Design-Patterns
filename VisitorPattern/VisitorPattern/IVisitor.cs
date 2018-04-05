namespace VisitorPattern {
    public interface IVisitor {

        void Visit(RealEstate realEstate);
        void Visit(BankAccount bankAccount);
        void Visit(Equities equities);
        void Visit(Loan loan);
    }
}