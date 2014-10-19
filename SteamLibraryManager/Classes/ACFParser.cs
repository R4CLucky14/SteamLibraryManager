using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using IronPython;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Reflection;

namespace SteamLibraryManager
{
    public class ACFParser
    {
        public string Parse(string path)
        {
            IDictionary<string, object> options = new Dictionary<string, object>();
            options["Arguments"] = new string[] { path };
            ScriptEngine engine = Python.CreateEngine(options);

            string str = "";

            var originalConsoleOut = Console.Out;
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                engine.Runtime.IO.RedirectToConsole();

                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "SteamLibraryManager.Scripts.parseacf.py";
                var result = "";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }

                engine.Execute(result);
                Console.SetOut(originalConsoleOut);

                writer.Flush();
                str = writer.GetStringBuilder().ToString();
            }

            return str;
        }
    }
}
