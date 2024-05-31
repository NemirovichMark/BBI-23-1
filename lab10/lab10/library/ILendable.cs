namespace lab10.library;

public interface ILendable
{
    public bool Borrow(string title);
    public void Return(string title);
}