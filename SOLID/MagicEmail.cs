using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal class MagicEmail : MagicCommunication
    {
        public override required string Address { get; init; }
    }
}
