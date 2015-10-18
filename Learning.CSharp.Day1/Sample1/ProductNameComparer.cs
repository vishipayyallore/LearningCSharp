using System;
using System.Collections;
using Learning.CSharp.DataModels;

namespace Learning.CSharp.Day1.Sample1
{
    public class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var product1 = x as Product;
            var product2 = y as Product;
            //Console.WriteLine($"{product1.Name} -> {product2.Name}");
            return product1.Name.CompareTo(product2.Name);
            
        }
    }
}