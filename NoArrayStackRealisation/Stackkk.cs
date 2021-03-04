using System.Collections;
using System.Collections.Generic;

namespace NoArrayStackRealisation
{
    public class Stackkk<T> : IStack<T>, IEnumerable
    {
        private int _amountOfNodes = 0;
        private Node<T> _lastnode = null;
        
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack empty.");
            }
            T valueToReturn = _lastnode.GetValue();
            _lastnode = _lastnode.GetNextNode();
            _amountOfNodes--;
            return valueToReturn;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack empty.");
            }
            return _lastnode.GetValue();
        }

        public void Push(T value)
        {
            Node<T> lastNode = new Node<T>(value);
            Node<T> preLastNode = _lastnode;
            _lastnode = lastNode;
            lastNode.SetNextNode(preLastNode);
            _amountOfNodes++;
        }

        public bool IsEmpty()
        {
            return _amountOfNodes == 0;
        }

        public IEnumerator GetEnumerator()
        {
            Node<T> curNode = _lastnode;
            for (int i = 0; i < _amountOfNodes; i++)
            {
                yield return curNode.GetValue();
                curNode = curNode.GetNextNode();
            }
        }

        public override string ToString()
        {
            List<T> stack = new List<T>();
            foreach (T x in this)
            {
                stack.Add(x);
            }
            return string.Join(" ", stack);
        }
    }
}