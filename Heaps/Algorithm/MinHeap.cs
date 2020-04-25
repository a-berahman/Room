using System;
using System.Collections.Generic;

namespace PlayGround.Heaps
{
    public class MinHeap
    {
        private readonly List<int> _items;
        //keep track of the last position of the array just by using the counts property of this list
        private int _lastPosition => _items.Count;

        public MinHeap(int value)
        {
            _items = new List<int>();
            _items.Add(value);
        }
        public int Peek()
        {
            if (_lastPosition == 0) throw new Exception("The heap is empty!");
            return _items[0];
        }
        public int Pop()
        {
            if (_lastPosition == 0) throw new Exception("The heap is empty!");
            int _oldMin = _items[0];
            _items[0] = _items[_lastPosition - 1];
            _items.RemoveAt(_lastPosition - 1);

            PercolateDow();

            return _oldMin;

        }
        public void Add(int value)
        {
            _items.Add(value);
            ParcolateUp();
        }
        private void Swap(int itemIndex, int parentIndex)
        {
            var temp = _items[itemIndex];
            _items[itemIndex] = _items[parentIndex];
            _items[parentIndex] = temp;
        }
        //bottomToTop
        private void ParcolateUp()
        {
            int _itemIndex = _lastPosition - 1;
            while (HasParent(_itemIndex) && _items[_itemIndex] < _items[GetParent(_itemIndex)])
            {
                int _parentIndex = GetParent(_itemIndex);
                Swap(_itemIndex, _parentIndex);
                _itemIndex = _parentIndex;
            }
        }
        //top to bottom
        private void PercolateDow()
        {
            int _itemIndex = 0;
            while (HasLeft(_itemIndex))
            {
                int _smaller = GetLeft(_itemIndex);
                if (HasRight(_itemIndex) && _items[GetRight(_itemIndex)] < _items[GetLeft(_itemIndex)])
                {
                    _smaller = GetRight(_itemIndex);
                }

                if (_items[_smaller] >= _items[_itemIndex]) break;

                Swap(_smaller, _itemIndex);
                _itemIndex = _smaller;
            }

        }
        private int GetParent(int index) => (index - 1) / 2;
        private int GetLeft(int index) => index * 2 + 1;
        private int GetRight(int index) => index * 2 + 2;
        private bool HasLeft(int index) => GetLeft(index) < _lastPosition;
        private bool HasRight(int index) => GetRight(index) < _lastPosition;
        private bool HasParent(int index) => index > 0;
    }
}