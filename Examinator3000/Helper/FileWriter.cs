using Examinator3000.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Examinator3000.Helper
{
    public class FileWriter
    {
        private static readonly string SavePath = Path.Combine(
          AppDomain.CurrentDomain.BaseDirectory,
          "tests.json"
      );

        /// <summary>
        /// Saves the current list of tests to disk as JSON.
        /// </summary>
        public static void SaveTests(List<Test> tests)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(tests, options);
            File.WriteAllText(SavePath, json);
        }

        /// <summary>
        /// Loads the list of tests from disk.
        /// Returns an empty list if the file doesn’t exist.
        /// </summary>
        public static List<Test> LoadTests()
        {
            if (!File.Exists(SavePath))
                return new List<Test>();

            string json = File.ReadAllText(SavePath);
            return JsonSerializer.Deserialize<List<Test>>(json) ?? new List<Test>();
        }

    }
}
