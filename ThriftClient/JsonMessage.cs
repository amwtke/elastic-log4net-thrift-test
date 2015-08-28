using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThriftClient
{
    class MessageObject
    {
        private DateTime timeStamp;
        private String message;
        public DateTime TimeStamp { get{return timeStamp;} set{timeStamp = value;} }
        public String Message { get { return message; } set { message = value; } }
    }
}
