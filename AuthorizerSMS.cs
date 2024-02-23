using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class AuthorizerSMS : Authorizer
    {
        public override void Authorize(string authString)
        {
            Console.WriteLine($"Authorized via security code {authString}");
        }
    }
}
