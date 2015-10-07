using Learning.CSharp.IDataModels;

namespace Learning.CSharp.DataModels
{

    public class Product : IEntity
    {

        /// <summary>
        /// Need for Mongo Db
        /// </summary>
        public Product() { }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        #region Properties
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name}: {Price}";
        }
        #endregion

    }

}
