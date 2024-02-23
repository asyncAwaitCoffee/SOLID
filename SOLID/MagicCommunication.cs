using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal abstract class MagicCommunication
    {
        public abstract required string Address { get; init; }
    }
}
