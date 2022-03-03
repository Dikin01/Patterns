using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Driver
    {
        public TypeLicense Lisence { protected set; get; }
        public string Name { protected set; get; }
        public string LastName { protected set; get; }

    }
}
