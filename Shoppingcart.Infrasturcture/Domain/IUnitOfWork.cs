using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart.Infrasturcture.Domain
{  
    public interface IUnitOfWork
    {
        int Commit();
        Task CommitAsync();
    }
}
