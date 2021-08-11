using System;
using System.Collections;

namespace Stack_Queue
{
    class MyStack : IEnumerable
    {
        private object[] _items;
        private int _count;

        public MyStack(int _defaultSize = 4)
        {
            if (_defaultSize == 0)
            {
                throw new ArgumentException(nameof(_defaultSize));
            }
            _items = new object[_defaultSize];
            _count = 0;
        }

        public void Print()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public void Push(object obj)
        {
            if (Count == Length)
            {
                Array.Resize(ref _items, Length * 2);
            }
            _items[Count] = obj;
            Count++;
        }

        public object Pop()
        {
            CheckLength();
            return _items[--Count];
        }

        public object Peek()
        {
            CheckLength();
            TrimToSize();
            return _items[^1];
        }

        public int Count
        {
            get => _count;
            private set => _count = value;
        }

        public void TrimToSize()
        {
            Array.Resize(ref _items, Count);
        }

        private int Length
        {
            get => _items.Length;
        }

        public void Clear()
        {
            Array.Resize(ref _items, 0);
        }

        private void CheckLength()
        {
            if (Length == 0)
            {
                throw new ArgumentException("Queue Empty!");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(_items);
        }
    }
}
