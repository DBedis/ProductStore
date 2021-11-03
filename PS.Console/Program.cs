using PS.Data;
using PS.Domain;
using PS.Service;
using System;
using System.Collections.Generic;

namespace PS.Console
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Provider P1 = new Provider 
            //{
            //    UserName="Provider1",
            //    Email="aa@aa.com",
            //    IsApproved=false,
            //    Password= "124465",
            //    ConfirmPassword= "124465",
            //    Id=1
            //};

            //System.Console.WriteLine("\n Provider initiale");
            //P1.GetDetails();

            ////Provider.SetIsApproved(P1);
            ////System.Console.WriteLine("\n Provider apres premiere methode");
            ////P1.GetDetails();

            ////System.Console.WriteLine("\n Provider apres deuxieme methode");
            ////bool isApp = P1.IsApproved;
            ////Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, ref isApp);
            ////P1.GetDetails();

            //System.Console.WriteLine("\n Login : " + P1.Login("Provider2", "124465"));
            //System.Console.WriteLine("\n Login Email : " + P1.Login("Provider1", "124465", "aa@aa.com"));

            //Product produit = new Product();
            //produit.GetMyType();

            //Biological biological = new Biological();
            //biological.GetMyType();

            //Chemical chemical = new Chemical();
            //chemical.GetMyType();

            //Provider PROV1 = new Provider
            //{
            //    UserName = "Provider1",
            //    Email = "aa@aa.com",
            //    IsApproved = false,
            //    Password = "124465",
            //    ConfirmPassword = "124465",
            //};

            //Provider PROV2 = new Provider
            //{
            //    UserName = "Provider2",
            //    Email = "aa@aa.com",
            //    IsApproved = false,
            //    Password = "124465",
            //    ConfirmPassword = "124465",
            //};

            //Provider PROV3 = new Provider
            //{
            //    UserName = "Provider3",
            //    Email = "aa@aa.com",
            //    IsApproved = false,
            //    Password = "124465",
            //    ConfirmPassword = "124465",
            //};

            //Provider PROV4 = new Provider
            //{
            //    UserName = "Provider4",
            //    Email = "aa@aa.com",
            //    IsApproved = false,
            //    Password = "124465",
            //    ConfirmPassword = "124465",
            //};

            //Provider PROV5 = new Provider
            //{
            //    UserName = "Provider5",
            //    Email = "aa@aa.com",
            //    IsApproved = false,
            //    Password = "124465",
            //    ConfirmPassword = "124465",
            //};

            //Category CAT1 = new Category
            //{
            //    Name = "CAT1",
            //};

            //Category CAT2 = new Category
            //{
            //    Name = "CAT2",
            //};

            //Category CAT3 = new Category
            //{
            //    Name = "CAT3",
            //};

            //Product PROD1= new Product
            //{
            //    Name="Product1",
            //    MyCategory=CAT1,
            //    Providers=new List<Provider>()
            //    {
            //        PROV1,PROV2,PROV3
            //    }, 
            //};

            //Product PROD2 = new Product
            //{
            //    Name = "Product2",
            //    MyCategory = CAT1,
            //    Providers = new List<Provider>()
            //    {
            //        PROV1
            //    },
            //};

            //Product PROD3 = new Product
            //{
            //    Name = "Product3",
            //    MyCategory = CAT3,
            //    Providers = new List<Provider>()
            //    {
            //        PROV1
            //    },
            //};

            //Product PROD4 = new Product
            //{
            //    Name = "Product4",
            //    MyCategory = null,
            //    Providers = new List<Provider>()
            //    {
            //        PROV4,PROV5,PROV3
            //    },
            //};

            //Product PROD5 = new Product
            //{
            //    Name = "Product5",
            //    MyCategory = CAT2,
            //    Providers = new List<Provider>(){},
            //};

            //Product PROD6 = new Product
            //{
            //    Name = "Product6",
            //    MyCategory = CAT3,
            //    Providers = new List<Provider>()
            //    {
            //        PROV4,PROV5
            //    },
            //};

            //CAT1.Products = new List<Product> { PROD1, PROD2 };
            //CAT2.Products = new List<Product> { PROD5 };
            //CAT3.Products = new List<Product> { PROD3, PROD6 };

            //PROV1.Products = new List<Product> { PROD1, PROD2, PROD3 };
            //PROV2.Products = new List<Product> { PROD1, PROD5 };
            //PROV3.Products = new List<Product> { PROD1 };
            //PROV4.Products = new List<Product> { PROD4, PROD6 };
            //PROV5.Products = new List<Product> { PROD4, PROD6 };

            ////PROV1.GetDetails();
            //PROV1.GetProducts("Price", "0");

            //PROD1.GetDetails();
            //List<Product> lp = new List<Product>();
            //ManageProduct mp = new ManageProduct(lp);
            //mp.UpperName(PROD1);
            //PROD1.GetDetails();

            using (var context = new PSContext())
            {
                //Create
                System.Console.WriteLine("Create");
                //Instancier un objet Product
                Product P = new Product
                {
                    Name = "Prod1",
                    DateProd = DateTime.Now
                };
                //Ajouter l'objet au DBSET
                context.Products.Add(P);
                //Persister les données
                context.SaveChanges();



                //Read All
                //System.Console.WriteLine("Read All");
                //foreach (Product p in context.Products)
                //{
                //    System.Console.WriteLine(p.ProductId + " " + p.Name);
                //}


                //Read Last
                //System.Console.WriteLine("Read Last");
                //var prod = context.Products.OrderBy(p => p.ProductId)
                //    .Last();
                //System.Console.WriteLine(prod.ProductId + " " + prod.Name);


                // Update
                //System.Console.WriteLine("Update");
                //prod.Name = "newName";
                //context.SaveChanges();
                //System.Console.WriteLine(prod.ProductId + " " + prod.Name);


                // Delete
                //System.Console.WriteLine("Delete the product");
                //context.Remove(prod);
                //context.SaveChanges();
            }




        }
    }
}
