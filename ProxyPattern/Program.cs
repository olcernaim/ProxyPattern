using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client client = new Client();

            RealSubject realSubject = new RealSubject();
            realSubject.Request("","");

            Proxy proxy = new Proxy(realSubject);
            proxy.Request("","");
        }
    }
}
