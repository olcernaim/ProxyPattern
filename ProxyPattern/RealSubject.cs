using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealSubject : ISubject
    {
        public void Request(string userName, string password)
        {
            Console.WriteLine("Real Subject : Handling Request");
        }
    }
}
