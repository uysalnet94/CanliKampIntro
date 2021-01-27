using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Customer cust1 = new Customer();
            //cust1.FirstName = "Furkan";
            //cust1.LastName = "Uysal";
            //cust1.Id = 1;
            //cust1.TCNo = "12134564897";
            //cust1.CustNo = "456456";


            //Yukarıda tanımda verilen kişidir. Şirket değildir. Bu tanım hatalıdır.
            //cust1.CompanyName = "??";

            //Gerçek Müşteri - Tüzel Müşteri ikisi farklı Müşteri tipi, birbirlerinin yerine kullanılamazlar. 

            //SOLID


            //Gerçek (Individual) Müşteri
            IndividualCust cust1 = new IndividualCust();
            cust1.Id = 1;
            cust1.CustNo = "46513";
            cust1.FirstName = "Furkan";
            cust1.LastName = "Uysal";
            cust1.TCNo = "65498765432155";

            //Tüzel (Coorporate) Müşteri
            CoorporateCust cust2 = new CoorporateCust();
            cust2.Id = 2;
            cust2.CustNo = "321654";
            cust2.CompanyName = "Kodlama.io";
            cust2.TaxNo = "9876543216";

            //Müşteri class ı hem IndividualCust ın hem de CoorporateCust ın referansını tutabiliyor.
            Customer cust3 = new IndividualCust();
            Customer cust4 = new CoorporateCust();

            CustManager custManager = new CustManager();
            custManager.Add(cust1);
            custManager.Add(cust2);
            custManager.Add(cust3);
            custManager.Add(cust4);
        }
    }
}
