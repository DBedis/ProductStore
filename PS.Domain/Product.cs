using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Product : Concept
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Category MyCategory { get; set; }
        public IList<Provider> Providers { get; set; }
        public int? CategoryId { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Name: " + Name +
                "\n Price: " + Price
                + "\n Quantity: " + Quantity);
        }

        public virtual void GetMyType()
        {
            System.Console.WriteLine("\n Product : UNKNOWN");
        }
    }
}
