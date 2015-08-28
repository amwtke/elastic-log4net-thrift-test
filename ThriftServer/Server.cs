using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift.Transport;
using Thrift.Protocol;
using Thrift.Server;
using Common;

namespace ThriftServer
{
    public class Server
    {
        public void Start()
        {
            TServerSocket serverTransport = new TServerSocket(7911, 0, false);
            ThriftCase.Processor processor = new ThriftCase.Processor(new BusinessImpl());
            TServer server = new TSimpleServer(processor, serverTransport);
            Console.WriteLine("Starting server on port 7911 ...");
            server.Serve();
        }
    }
}
