using System;

namespace DictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> plakalar=new MyDictionary<int>();
            plakalar.Add(01);
            plakalar.Add(06);
            plakalar.Add(34);
            plakalar.Add(38);
            Console.WriteLine(plakalar.Length);
        }
    }

    class MyDictionary<T>
    {
        private T[] _array;
        private T[] _tempArray;

        public MyDictionary()
        {
            _array=new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array=new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = _array[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Length
        {
            get { return _array.Length; }
        }
    }
}
