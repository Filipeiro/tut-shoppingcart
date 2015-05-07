using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart.Infrasturcture.Domain
{
    
    interface IReadOnlyRepository<T, TId> where T : BaseEntity<TId>, IAggregateRoot
    {
        T GetById(TId id);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        //Execute Stored Procedure

        IEnumerable<T> ExecWIthStoreProcedure<T>(string query);
        void ExecuteWithStoreProcedure(string query, params object[] parameters);

        //Async Programming
        Task<T> GetByIdAsync(TId id);
        Task<T> GetAsync(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where);

        //Execute Stored Procedures Async
        Task<IEnumerable<T>> ExecWithStoreProcedureAsync<T>(string query, params object[] parameters);
        Task ExecuteWithStoreProcedureAsync(string query, params object[] parameters);
    }
}
