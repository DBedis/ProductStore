using PS.Domain;
using PS.Service;
using PS.Data;
using System;
using System.Collections.Generic;


namespace ProductStore
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new PSContext())
            {
                Product P = new Product
                {
                    Name = "Prod1",
                    DateProd = DateTime.Now,
                };
            }

            /*Provider PROV1 = new Provider
            {
                UserName = "Provider1",
                Email = "aa@aa.com",
                IsApproved = false,
                Password = "124465",
                ConfirmPassword = "124465",
            };

            Provider PROV2 = new Provider
            {
                UserName = "Provider2",
                Email = "aa@aa.com",
                IsApproved = false,
                Password = "124465",
                ConfirmPassword = "124465",
            };

            Provider PROV3 = new Provider
            {
                UserName = "Provider3",
                Email = "aa@aa.com",
                IsApproved = false,
                Password = "124465",
                ConfirmPassword = "124465",
            };

            Provider PROV4 = new Provider
            {
                UserName = "Provider4",
                Email = "aa@aa.com",
                IsApproved = false,
                Password = "124465",
                ConfirmPassword = "124465",
            };

            Provider PROV5 = new Provider
            {
                UserName = "Provider5",
                Email = "aa@aa.com",
                IsApproved = false,
                Password = "124465",
                ConfirmPassword = "124465",
            };

            Category CAT1 = new Category
            {
                Name = "CAT1",
            };

            Category CAT2 = new Category
            {
                Name = "CAT2",
            };

            Category CAT3 = new Category
            {
                Name = "CAT3",
            };

            Product PROD1 = new Product
            {
                Name = "Product1",
                myCategory = CAT1,
                Providers = new List<Provider>()
                {
                    PROV1,PROV2,PROV3
                },
            };

            Product PROD2 = new Product
            {
                Name = "Product2",
                myCategory = CAT1,
                Providers = new List<Provider>()
                {
                    PROV1
                },
            };

            Product PROD3 = new Product
            {
                Name = "Product3",
                myCategory = CAT3,
                Providers = new List<Provider>()
                {
                    PROV1
                },
            };

            Product PROD4 = new Product
            {
                Name = "Product4",
                myCategory = null,
                Providers = new List<Provider>()
                {
                    PROV4,PROV5,PROV3
                },
            };

            Product PROD5 = new Product
            {
                Name = "Product5",
                myCategory = CAT2,
                Providers = new List<Provider>() { },
            };

            Product PROD6 = new Product
            {
                Name = "Product6",
                myCategory = CAT3,
                Providers = new List<Provider>()
                {
                    PROV4,PROV5
                },
            };

            CAT1.Products = new List<Product> { PROD1, PROD2 };
            CAT2.Products = new List<Product> { PROD5 };
            CAT3.Products = new List<Product> { PROD3, PROD6 };

            PROV1.Products = new List<Product> { PROD1, PROD2, PROD3 };
            PROV2.Products = new List<Product> { PROD1, PROD5 };
            PROV3.Products = new List<Product> { PROD1 };
            PROV4.Products = new List<Product> { PROD4, PROD6 };
            PROV5.Products = new List<Product> { PROD4, PROD6 };


            List<Product> lp = new List<Product>();
            ManageProduct mp = new ManageProduct(lp);
            Console.WriteLine(PROD1.Name);
            mp.UpperName(PROD1);
            Console.WriteLine(PROD1.Name);*/
        }
    }
}
