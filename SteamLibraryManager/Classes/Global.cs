using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;

namespace SteamLibraryManager
{
    /// <summary>
    /// Singleton class that holds functions and variables.
    /// </summary>
    public sealed class Global
    {
        /// <summary>
        /// Lazy initialization
        /// </summary>
        private static readonly Lazy<Global> lazy = new Lazy<Global>(() => new Global());

        /// <summary>
        /// Class instance
        /// </summary>
        public static Global Instance { get { return lazy.Value; } }

        /// <summary>
        /// Holds all found SteamLibraries
        /// </summary>
        public List<SteamLibrary> Libraries = new List<SteamLibrary>();

        /// <summary>
        /// Steam installation path
        /// </summary>
        private string SteamPath;
        
        /// <summary>
        /// Get steam RegistryKey from the registry
        /// </summary>
        /// <returns></returns>
        private RegistryKey GetSteamSubKey()
        {
            return Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam");
        }

        /// <summary>
        /// Searches in the windows registry for steam libraries
        /// </summary>
        public void FindSteamLibraries()
        {
            //Get steam registry subkey
            RegistryKey rkSteam = GetSteamSubKey();
            if (rkSteam == null) throw new SteamNotFoundException();

            //Get steam installation path
            string path = (string) rkSteam.GetValue("SteamPath");
            if (path == null) 
                throw new SteamNotFoundException();
            this.SteamPath = path;

            //Check if config.vdf exists
            if (!Directory.Exists(path)) 
                throw new SteamNotFoundException();
            string configPath = String.Format("{0}/config/config.vdf", path);
            if (!File.Exists(configPath)) 
                throw new SteamNotFoundException();

            //Open steam config file
            StreamReader steamConfig = new StreamReader(configPath);
            if(steamConfig == null)
                throw new SteamNotFoundException();
            if (steamConfig.BaseStream.Length == -1 || steamConfig.BaseStream.Length == 0)
                throw new SteamNotFoundException();

            //TODO: come up with a better method that does not rely on a keyword
            //searches in the string for *SteamLibrary* and extracts the paths
            string data = steamConfig.ReadToEnd();
            data = data.Replace("\t", "");
            data = data.Replace("\r", "");
            data = data.Replace("\n", "");
            data = data.Replace("{", "");
            data = data.Replace("}", "");
            List<string> temp = data.Split('"').ToList();
            temp.RemoveAll(str => temp.Any(s => !str.Contains("SteamLibrary")));

            foreach (string s in temp)
            {
                if(Directory.Exists(s))
                    this.Libraries.Add(new SteamLibrary(s.Replace(@"\\\\", @"\\")));
            }

            if(Directory.Exists(this.SteamPath + "/SteamApps"))
                this.Libraries.Add(new SteamLibrary(this.SteamPath.Replace("/", "\\")));
        }

        private Global()
        {
        }
    }
}
