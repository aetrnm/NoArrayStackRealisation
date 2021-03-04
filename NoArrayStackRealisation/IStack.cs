namespace NoArrayStackRealisation
{
    public interface IStack<T>
    {
        T Pop();
        T Peek();
        void Push(T value);
        bool IsEmpty();
    }
}