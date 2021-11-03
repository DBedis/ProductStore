using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS.Service
{
    public class ManageProduct
    {
        public List<Product> listProduct = new List<Product>();

        public ManageProduct(List<Product> listProduct)
        {
            this.listProduct = listProduct;
        }

        public IEnumerable<Chemical> Get5Chemical(double price)
        {
            var req =
                from p in listProduct.OfType<Chemical>()
                where p.Price > price
                select p;

            return req.Take<Chemical>(5);
            // our return req.Take(5).OfType<Chemical>();
        }

        public IEnumerable<Product> GetProductPrice(double price)
        {
            var req =
                from p in listProduct
                where p.Price > price
                select p;

            return req.Skip(2);
        }

        public double GetAveragePrice()
        {
            var req =
                from p in listProduct
                select p.Price;

            return req.Average();
        }

        public Product GeMaxPrice()
        {
            var req =
                from p in listProduct
                where p.Price.Equals((from pTemp in listProduct
                                 select pTemp.Price).Max())
                select p;

            return req.FirstOrDefault();
        }

        public int GetCountProduct(String city)
        {
            var req =
                from p in listProduct
                where ((Chemical)p).Myadresse.City.Equals(city)
                select p;

            return req.Count();
        }

        public List<Chemical> GetChemicalCity()
        {
            var req =
                from p in listProduct.OfType<Chemical>()
                orderby p.Myadresse.City
                select p;

            return req.ToList();
        }

        //public List<Chemical> GetChemicalGroupByCity()
        //{
        //    var req =
        //        from p in listProduct.OfType<Chemical>()
        //        group p.City by p.City into cityGroup
        //        orderby cityGroup
        //        select cityGroup;

        //    return req.ToList();
        //}
    }
}
