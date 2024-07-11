namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Alican");
            dictionary.Add(2, "Ahmet");
            dictionary.Add(3, "Deniz");
            Console.WriteLine(dictionary.Count);


            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Alican");
            myDictionary.Add(2, "Ahmet");
            myDictionary.Add(3, "Deniz");
            Console.WriteLine(myDictionary.CountValues);
        }
    }


    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item) 
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }


    class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        TKey[] _tempKeys;
        TValue[] _tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        public void Add(TKey key, TValue value) 
        {
            _tempKeys = _keys;
            _tempValues = _values;
            _keys = new TKey[_keys.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
            }
            _values = new TValue[_values.Length + 1];
            
            for (int i = 0; i < _tempValues.Length; i++)
            {
                _values[i] = _tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        

        public int CountKeys
        {
            get { return _keys.Length; }
        }

        public int CountValues
        {
            get { return _values.Length; }
        }

    }
}
