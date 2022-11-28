using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Utils
{
    public class Utility
    {
        public static string getProjectRootDirectory() {

             string currentDirectory =  Directory.GetCurrentDirectory();
            return currentDirectory.Split("bin")[0];
        }
    }
}
