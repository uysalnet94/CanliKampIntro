using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product();

            prod1.Name = "Elma";
            prod1.Price = 15;
            prod1.Description = "Amasya Elması";

            Product prod2 = new Product();

            prod2.Name = "Karpuz";
            prod2.Price = 80;
            prod2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { prod1, prod2 };
            
            
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("--------------Methods---------------");
            //instance
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(prod1);
            sepetManager.Add(prod2);



            sepetManager.Add2("Armut", "Yeşil Armut", 12,58);
            sepetManager.Add2("Elma", "Yeşil Elma", 12, 85);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu",20 ,15);

        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice
