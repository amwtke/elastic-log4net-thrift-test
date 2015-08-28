using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.ElasticSearch;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class LogHelper
    {
        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        #region static void WriteLog(Type t, Exception ex)

        public static void WriteLog(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);
        }

        #endregion

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        #region static void WriteLog(Type t, string msg)

        static LogHelper()
        {
           System.Reflection.Assembly.LoadFrom("log4stash.dll");
        }
        public static void WriteLog(Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error(msg);
        }

        public static void WriteLogInfo(Type t, object message)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Info(message);
        }
        #endregion


    }
}

