using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Learning.CSharp.DataModels;
using Learning.CSharp.IDataModels;

namespace Learning.CSharp.IDataRepositories
{

    public interface IRepository<T> where T : IEntity
    {
        #region Properties
        Task<List<T>>  List { get; }
        #endregion

        #region Methods
        Task<HttpStatusCode> Add(T entity);

        IEnumerable<T> GetPrdocuts(Func<Product, bool> action);
        void Delete(T entity);
        void Update(T entity);
        Task<T> FindById(string id);
        #endregion
    }

}
