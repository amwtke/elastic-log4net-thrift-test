using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift.Transport;
using Thrift.Protocol;
using Common;

namespace ThriftClient
{
    class Program
    {
        static Dictionary<String, String> map = new Dictionary<String, String>();
        static List<Blog> blogs = new List<Blog>();
        static void Main(string[] args)
        {
            MessageObject mo1 = new MessageObject{TimeStamp = DateTime.Now, Message="begin process...."};
            LogHelper.WriteLogInfo(typeof(Program), mo1);

			TTransport transport = new TSocket("localhost", 7911);
            TProtocol protocol = new TBinaryProtocol(transport);
			ThriftCase.Client client = new ThriftCase.Client(protocol);
			transport.Open();
			Console.WriteLine("Client calls .....");
			map.Add("blog", "http://www.javabloger.com");

			client.testCase1(10, 21, "3");
			client.testCase2(map);
			client.testCase3();

			Blog blog = new Blog();
			//blog.setContent("this is blog content".getBytes());
            blog.CreatedTime = DateTime.Now.Ticks;
			blog.Id = "123456";
			blog.IpAddress = "127.0.0.1";
			blog.Topic = "this is blog topic";
			blogs.Add(blog);
			
			client.testCase4(blogs);
			
			transport.Close();
            //LogHelper.WriteLog(typeof(Program), "end process......");
            Console.ReadKey();
        }
    }
}
