using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Selenium_Framework_POC.Helpers
{
    public class LogHelpers
    {
        //Global Declaration of Unique Log File Name
        private static string _logFileNAme = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamw = null;
        //Create a file which can store Log information 
        public static void CreateLogfile()
        {
            string dir = @"C:\Users\byata\Documents\SeleniumFramework\";
            if(Directory.Exists(dir))
            {
                _streamw = File.AppendText(dir + _logFileNAme + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamw = File.AppendText(dir + _logFileNAme + ".log");
            }
        }
        //Create a method whhich can write text in log file
        public static void Write(string logMessage)
        {
            _streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamw.WriteLine("    {0}", logMessage);
            _streamw.Flush();
        }

    }
}
