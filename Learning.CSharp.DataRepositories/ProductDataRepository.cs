using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Learning.CSharp.DataModels;
using Learning.CSharp.IDataRepositories;
using Learning.CSharp.MongoDbDataStore;
using MongoDB.Driver;

namespace Learning.CSharp.DataRepositories
{

    public class ProductsRepository : IRepository<Product>
    {
        #region Variables.
        private readonly ProductsContext _productsContext;
        #endregion

        public ProductsRepository()
        {
            //TODO: Using Dependency Injenction
            _productsContext = new ProductsContext();
        }

        #region Properties.

        public List<Product> List
        {
            get
            {
                var filter = Builders<Product>.Filter.Exists("_id");
                return _productsContext.Products.FindAsync(filter).Result.ToListAsync().Result; 
            }
        }
        #endregion

        #region Methods
        public async Task<HttpStatusCode> Add(Product entity)
        {
            await _productsContext.Products.InsertOneAsync(entity);
            return HttpStatusCode.Accepted;
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> FindById(string id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
