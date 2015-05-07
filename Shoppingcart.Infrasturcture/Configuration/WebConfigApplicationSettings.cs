using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart.Infrasturcture.Domain.Configuration
{
    public class WebConfigApplicationSettings : IApplicationSettings
    {
        string LoggerName { get; }
    }
}
