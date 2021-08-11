using System;
using System.Collections;

namespace Stack_Queue
{
    class MyQueue : IEnumerable
    {
        private object[] _items;
        private int _count;

        public MyQueue(int _defaultSize = 4)
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

        public void Enqueue(object obj)
        {
            if (Count == Length)
            {
                Array.Resize(ref _items, Length * 2);
            }
            _items[Count] = obj;
            Count++;
        }

        public object Dequeue()
        {
            CheckLength();
            object firstItem = _items[0];
            Count--;
            for (int i = 0; i < Length - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            Array.Resize(ref _items, Length - 1);
            TrimToSize();
            return firstItem;
        }

        public object Peek()
        {
            CheckLength();
            return _items[0];
        }

        public bool Contains(object obj)
        {
            if (IndexOf(obj) != -1)
            {
                return true;
            }
            return false;
        }

        private int IndexOf(object obj)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_items[i].Equals(obj))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Count
        {
            get => _count;
            private set => _count = value;
        }

        private int Length
        {
            get => _items.Length;
        }

        public void TrimToSize()
        {
            Array.Resize(ref _items, Count);
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
