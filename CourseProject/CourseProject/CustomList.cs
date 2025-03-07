using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _size;
        private int _capacity;

        public int Count => _size;
        public int Capacity => _capacity;

        public CustomList()
        {
            _size = 0;
            _capacity = 5;
            _items = new T[_capacity];
        }

        public CustomList(int capacity)
        {
            _size = 0;
            _capacity = capacity;
            _items = new T[_capacity];
        }

        public CustomList(T[] items)
        {
            _size = items.Length;
            _capacity = items.Length;
            _items = new T[_capacity];
            Array.Copy(items, _items, _size);
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _size)
                    throw new IndexOutOfRangeException();
                _items[index] = value;
            }
        }

        public void Add(T newItem)
        {
            if (_size == _capacity)
            {
                Resize(_capacity * 2);
            }
            _items[_size++] = newItem;
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(_items, item, 0, _size);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _size)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            for (int i = index; i < _size - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _items[_size - 1] = default(T);
            _size--;
        }

        private void Resize(int newCapacity)
        {
            T[] newItems = new T[newCapacity];
            Array.Copy(_items, newItems, _size);
            _items = newItems;
            _capacity = newCapacity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
