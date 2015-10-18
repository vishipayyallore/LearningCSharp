using System;
using System.Collections.Generic;
using Learning.CSharp.DataModels;

namespace Learning.CSharp.Day1.Infrastructure
{

    public class ProductNameComparerV2 : IComparer<Product>
    {
        public int Compare(Product first, Product second)
        {
            return string.Compare(first.Name, second.Name, StringComparison.Ordinal);
        }
    }

}