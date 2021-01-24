using System;
using System.Collections.Generic;
using System.Text;

namespace Day4HomeWorkDictionary
{
    class MyDictionary<T, D>
    {
        // Dictionary lerde iki farklı eleman tipi verilebileceği  için iki tane array tanımı yaptım.

        //kullanılacak olan ana arrayler
        T[] items;
        D[] items2;

        public MyDictionary()
        {
            items = new T[0];
            items2 = new D[0];
        }

        public void Add(T item, D item2)
        {
            // Yedek arrayler ve yedekleme
            T[] tempArray = items;
            D[] tempArray2 = items2;

            // ana arraylere eski boyutundan bir fazla alan ekleme ve yenileme
            items = new T[items.Length + 1];
            items2 = new D[items2.Length + 1];

            // eski değerleri atama işlemleri
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }

            //Yeni İtem ın eklenmesi
            items[items.Length - 1] = item;
            items2[items2.Length - 1] = item2;
        }

        public T[] Items1
        {
            get
            {
                return items;
            }
        }
        public D[] Items2
        {
            get
            {
                return items2;
            }
        }
    }
}
