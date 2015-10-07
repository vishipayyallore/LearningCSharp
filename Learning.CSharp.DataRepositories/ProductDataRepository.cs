using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Learning.CSharp.DataModels;
using Learning.CSharp.IDataRepositories;
using Learning.CSharp.MongoDbDataStore;

namespace Learning.CSharp.DataRepositories
{

    public class ProductsRepository : IRepository<Product>
    {

        private readonly ProductsContext _productsContext;

        public ProductsRepository()
        {
            //TODO: Using Dependency Injenction
            _productsContext = new ProductsContext();
        }

        public IEnumerable<Product> List { get; }

        public async Task<HttpStatusCode> Add(Product entity)
        {
            await _productsContext.Products.InsertOneAsync(entity);
            return HttpStatusCode.Accepted;
        }

        public void Delete(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> FindById(string id)
        {
            throw new System.NotImplementedException();
        }
    }

}
