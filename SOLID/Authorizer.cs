using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal abstract class Authorizer
    {
        public abstract void Authorize(string authString);
    }
}
