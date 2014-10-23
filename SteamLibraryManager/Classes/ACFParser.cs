using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace SteamLibraryManager
{
    public class ACFParser
    {
        public string Parse(string path)
        {
            IDictionary<string, object> options = new Dictionary<string, object>();
            options["Arguments"] = new string[] { path };

            string str = "";

            var originalConsoleOut = Console.Out;
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);


                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "SteamLibraryManager.Scripts.parseacf.py";
                var result = "";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }

                Console.SetOut(originalConsoleOut);

                writer.Flush();
                str = writer.GetStringBuilder().ToString();
            }

            return str;
        }
    }
}
