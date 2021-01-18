using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            int x;
            Console.WriteLine("1: Müşteri Ekleme \n2: Müşteri Silme \n3: Müşteri Listeleme \nLütfen yapmak istediğiniz işlemi seçin : ");
            x = Convert.ToInt32(Console.ReadLine());



            Customer cust1 = new Customer();

            cust1.Id = 1;
            cust1.Name = "Furkan";
            cust1.Surname = "Uysal";
            cust1.Age = 25;

            Customer cust2 = new Customer();

            cust1.Id = 2;
            cust2.Name = "Ali";
            cust2.Surname = "Kazık";
            cust2.Age = 54;
            CustManager custManager = new CustManager();



            switch (x)
            {
                case 1:
                    custManager.Add(cust1);
                    custManager.Add(cust2);
                    break;
                case 2:
                    custManager.Delete(cust1);
                    break;
                case 3:
                    Customer[] custs = new Customer[] { cust1, cust2 };
                    custManager.Lists(custs);
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş yaptınız");
                    break;
            }
        }
    }
}
