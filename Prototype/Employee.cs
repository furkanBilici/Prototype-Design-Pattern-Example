using Prototype.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Employee : Person
    {
        public int salary {  get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
