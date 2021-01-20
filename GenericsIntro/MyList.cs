using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>// bana bir tip ver ona göre şekilleneceğim.
    {
        T[] items;
        //constructor - class çağırıldığı anda çalışıyor.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;        }

    }
}
