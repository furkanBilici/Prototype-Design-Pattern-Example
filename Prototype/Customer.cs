using Prototype.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Customer : Person
    {
        public string order {  get; set; }
        public override Person GetPerson()
        {
            throw new NotImplementedException();
        }
    }
}
