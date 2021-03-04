namespace NoArrayStackRealisation
{
    public class Node<T>
    {
        private readonly T _value;
        private Node<T> _next;

        public Node(T value)
        {
            _value = value;
        }

        public Node<T> GetNextNode()
        {
            return _next;
        }

        public void SetNextNode(Node<T> nodeToSet)
        {
            _next = nodeToSet;
        }

        public T GetValue()
        {
            return _value;
        }
    }
}