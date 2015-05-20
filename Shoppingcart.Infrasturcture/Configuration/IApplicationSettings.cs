using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart.Infrasturcture.Domain.Configuration
{
    public interface IApplicationSettings
    {
        string LoggerName { get;}
        
        string EmailAddress { get; }
        string Credential { get; }
    }
}
