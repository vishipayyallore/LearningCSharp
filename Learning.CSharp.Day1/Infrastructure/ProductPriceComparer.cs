using System.Collections;
using Learning.CSharp.DataModels;

namespace Learning.CSharp.Day1.Infrastructure
{
    public class ProductPriceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var product1 = x as Product;
            if (product1 == null)
                return -1;
            var product2 = y as Product;
            if (product2 == null)
                return -1;
            return product1.Price.CompareTo(product2.Price);
        }
    }
}