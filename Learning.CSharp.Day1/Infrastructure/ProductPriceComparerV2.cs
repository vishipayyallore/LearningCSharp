using System.Collections;
using System.Collections.Generic;
using Learning.CSharp.DataModels;

namespace Learning.CSharp.Day1.Infrastructure
{

    public class ProductPriceComparerV2 : IComparer<Product>
    {
        public int Compare(Product product1, Product product2)
        {
            return product1.Price.CompareTo(product2.Price);
        }
    }

}