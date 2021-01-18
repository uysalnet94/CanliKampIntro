using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustManager
    {
        public void Add(Customer cust)
        {
            Console.WriteLine("Müşteriler Eklendi : " + cust.Name);
        }

        public void Delete(Customer cust)
        {
            Console.WriteLine("Müşteri Silindi : " + cust.Name);
        }

        public void Lists(Customer[] custs)
        {
            foreach (Customer cust in custs)
            {
                Console.WriteLine(cust.Name);
                Console.WriteLine(cust.Surname);
                Console.WriteLine(cust.Age);
                Console.WriteLine("-------------");
            }
        }
    }
}