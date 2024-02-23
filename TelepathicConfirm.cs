using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class TelepathicConfirm : MagicCommunication
    {
        public override required string Address { get; init; }
    }
}
