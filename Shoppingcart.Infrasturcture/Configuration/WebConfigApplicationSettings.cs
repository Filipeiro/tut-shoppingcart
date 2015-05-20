﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart.Infrasturcture.Domain.Configuration
{
    public class WebConfigApplicationSettings : IApplicationSettings
    {
        public string LoggerName { get { return ConfigurationManager.AppSettings["LoggerName"]; } }
        public string EmailAddress { get { return ConfigurationManager.AppSettings["EmailAddress"]; } }
        public string Credential { get { return ConfigurationManager.AppSettings["Credential"]; } }

    }
}
