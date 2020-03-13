using System;

namespace CSOOPPatterns.Behavioral.Iterator
{
    public class IterableLinkedStack<T> : IIterable<T>
    {
        private class StackItem<T>
        {
            public T value;
            public StackItem<T> next;
        }

        private StackItem<T> _head;

        public bool IsEmpty => _head == null;

        public void Push(T value)
        {
            var peek = new StackItem<T>()
            {
                value = value,
                next = _head
            };
            _head = peek;
        }
        
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Trying to get a value of an empty stack");
            }
            return _head.value;
        }

        public T Pop()
        {
            var value = Peek();
            _head = _head.next;
            return value;
        }

        public IIterator<T> GetIterator()
        {
            return new Iterator(_head);
        }

        private class Iterator : IIterator<T>
        {
            private StackItem<T> _current;
            public T Current => _current.value;

            internal Iterator(StackItem<T> current)
            {
                _current = current;
            }

            public bool Finished => _current == null;
            
            public void MoveNext()
            {
                _current = _current.next;
            }
        }
    }
}