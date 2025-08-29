using Examinator3000.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator3000
{
    static public class Globals
    {
        static List<Test>LoadedTests = new List<Test>();
        static Test currentActiveTest;

        public static void AddTest(string testName) 
        {
            currentActiveTest = new Test(testName);
            LoadedTests.Add(currentActiveTest);
        }
    }
}
