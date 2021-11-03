using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
    public static class ProductExtension
    {
        public static void UpperName(this ManageProduct mp, Product p)
        {
            p.Name = p.Name.ToUpper();
        }

        public static bool InCategory(this ManageProduct mp, Product p, Category c)
        {
            return p.MyCategory.Name == c.Name;
        }
    }
}
