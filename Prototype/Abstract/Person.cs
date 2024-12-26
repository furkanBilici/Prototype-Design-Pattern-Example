using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Abstract
{
    public abstract class Person
    {
        public abstract Person Clone();

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
