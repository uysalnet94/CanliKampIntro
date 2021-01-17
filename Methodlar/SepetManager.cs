using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //Naming Convention
        public void Add(Product prod)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + prod.Name);
        }

        public void Add2(string prodName, string description, double price, int stock)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + prodName);
        }

    }
}
