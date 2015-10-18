using System;
using System.Collections.Generic;
using System.Linq;
using Learning.CSharp.DataModels;
using Learning.CSharp.DataRepositories;

namespace Learning.CSharp.Day1.Infrastructure
{

    public class ProductsHelper
    {

        #region Methods
        public static List<Product> RetrieveProducts(Func<Product, bool> action)
        {
            var productsRepository = new ProductsRepository();
            return (action == null
                ? productsRepository.List.Result.ToList()
                : productsRepository.GetPrdocuts(action).ToList());
        }
        #endregion

    }

}