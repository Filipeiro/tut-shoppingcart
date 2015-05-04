using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart.Infrasturcture.Domain
{
    public class ValidationRule
    {
        private string _property;
        public string _rule;

        public ValidationRule(string property, string rule) 
        {
            _property = property;
            _rule = rule;
        }

        public string Property
        {
            get { return _property; }
            set { _property = value; }
        }

        public string ru
    }
}
