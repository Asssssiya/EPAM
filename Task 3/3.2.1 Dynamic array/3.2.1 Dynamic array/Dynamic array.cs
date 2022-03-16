using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._1_Dynamic_array
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] _array;

        private int _length;

        private const int _defaultCapacity = 8;
        private const int _multiplierCapacity = 2;

        public int Capacity => _array.Length;
        public int Length => _length;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                _array[index] = value;
            }
        }

        public DynamicArray() : this(_defaultCapacity)
        {
        }

        public DynamicArray(int capacity)
        {
            _array = new T[capacity];
        }
        public DynamicArray(IEnumerable<T> array)
        {
            _array = new T[array.Count()];

            int i = 0;
            foreach (var item in array)
            {
                _array[i] = item;
                i++;
            }
        }

        public void Add(T item)
        {
            if (_length == Capacity)
            {
                ExtendArray(Capacity * _multiplierCapacity);

            }
            _array[_length] = item;
            _length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            int difference = Capacity - Length;
            int collectionCount = collection.Count();

            bool isExtensionNeeded = difference < collectionCount;

            if (isExtensionNeeded)
            {
                int overFlow = collectionCount - difference;
                ExtendArray(Capacity + overFlow);
            }

            foreach (var item in collection)
            {
                _array[_length] = item;
                _length++;
            }
        }

        public bool Remove(T item)
        {
            int index = Array.FindIndex(_array, i => i.Equals(item));

            if (index == -1)
            {
                return false;
            }

            for (int i = index + 1; i < _length; i++)
            {
                _array[i - 1] = _array[i];
            }
            _length--;
            return true;
        }

        public bool Insert(T item, int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            bool isExtensionNeeded = _length == Capacity;
            if (isExtensionNeeded)
            {
                ExtendArray(Capacity * _multiplierCapacity);
            }

            for (int i = _length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[index] = item;

            _length++;

            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _length; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void ExtendArray(int newLength)
        {
            T[] tempArray = new T[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tempArray[i] = _array[i];
            }

            _array = tempArray;
        }
    }
}

