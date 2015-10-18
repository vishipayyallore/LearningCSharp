using Learning.CSharp.DataModels;
using Learning.CSharp.MongoStore;
using Learning.CSharp.Utilities;
using MongoDB.Driver;

namespace Learning.CSharp.MongoDbDataStore
{

    public class ProductsContext
    {
        #region Properties.
        private static IMongoDatabase _mongoDatabase;
        private static readonly MongoDataStore MongoDataStoreInstance = MongoDataStore.DataStoreInstance;
        private static string _productsCollectionName;
        #endregion

        public ProductsContext()
        {
            _productsCollectionName = ConfigurationHelper.GetConfigurationValue("ProductsCollectionName");
            _mongoDatabase = MongoDataStoreInstance.DatabaseInstance;
        }

        #region Properties
        public IMongoCollection<Product> Products => _mongoDatabase.GetCollection<Product>(_productsCollectionName);
        #endregion
    }

}
