using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Utils
{
    public class ReportLog
    {
        public static void pass(string message) {
            ExtentTestManager.getTest().Pass(message); 
        }

        public static void fail(string message , MediaEntityModelProvider media=null)
        {
            ExtentTestManager.getTest().Fail(message,media);
        }

        public static void skip(string message)
        {
            ExtentTestManager.getTest().Skip(message);
        }
    }
}
