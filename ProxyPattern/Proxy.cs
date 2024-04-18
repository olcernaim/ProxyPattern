using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Request(string userName, string password)
        {
            if (Login(userName, password))
            {
                _realSubject.Request(userName, password);
                LogAccess();
            }
        }

        public bool Login(string userName, string password)
        {
            Console.WriteLine("Checking");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Log Access");
        }
    }
}
