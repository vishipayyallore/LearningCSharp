using System.Collections;
using Learning.CSharp.DataModels;

namespace Learning.CSharp.Day1.Sample1
{
    public class ProductPriceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var product1 = x as Product;
            var product2 = y as Product;
            return product1.Price.CompareTo(product2.Price);
        }
    }
}