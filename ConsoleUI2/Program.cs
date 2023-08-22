using Business.Concrete;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            InMemoryCampaignDal inMemoryCampaignDal = new InMemoryCampaignDal();
            InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            InMemoryCustomerDal inMemoryCustomerDal = new InMemoryCustomerDal();
            
            InMemorySaleDal inMemorySaleDal = new InMemorySaleDal(inMemoryCustomerDal, inMemoryProductDal);

            CampaignManager campaignManager = new CampaignManager(inMemoryCampaignDal);
            ProductManager productManager = new ProductManager(inMemoryProductDal);
            
            CustomerManager customerManager = new CustomerManager(inMemoryCustomerDal);
            SaleManager saleManager = new SaleManager(inMemorySaleDal);


           

            //Sistemden Ürün Getirme
            Product product1 = inMemoryProductDal.GetByIdProduct(1);
            Product product2 = inMemoryProductDal.GetByIdProduct(2);
            //Sistemden Ürün Getirme

            //Sistemden Musteri Getirme
            Customer customer1 = inMemoryCustomerDal.GetById(1);
            Customer customer2 = inMemoryCustomerDal.GetById(2);
            //Sistemden Musteri Getirme



            //KAMPANYA UYGULAMA
            Campaign campaign = inMemoryCampaignDal.GetByIdCampaign(1);

            campaignManager.CampaignToProduct(campaign, product1);
            Console.WriteLine(product1.Price);
            //KAMPANYA UYGULAMA








            //Musterilerin Basketine Product Ekleme
            customerManager.AddToBasket(product2, customer1,product2.Name);
            customerManager.AddToBasket(product1, customer1,product1.Name);
            customerManager.AddToBasket(product1, customer2,product1.Name);
            //Musterilerin Basketine Product Ekleme



            //Musteriler icin Buy Islemleri
            saleManager.CustomerBuy(customer1);
            saleManager.CustomerBuy(customer2);
            //Musteriler icin Buy Islemleri
            
            



            List<Sale> allSales = inMemorySaleDal.GetAll();
            foreach (var s in allSales)
            {
                Console.WriteLine($"Customer ID: {s.customer.Id}, Total Price: {s.totalprice}",);
            }

            Console.ReadLine();
        }
    }
}
