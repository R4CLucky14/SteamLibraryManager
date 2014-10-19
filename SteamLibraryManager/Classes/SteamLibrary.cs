using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SteamLibraryManager
{
    /// <summary>
    /// Holds specific information about a SteamLibrary
    /// </summary>
    public class SteamLibrary
    {
        private string _path;

        /// <summary>
        /// The full path of the SteamLibrary
        /// </summary>
        public string Path { get { return _path; } set { this._path = value; } }

        /// <summary>
        /// A list containing all games in the SteamLibrary
        /// </summary>
        public List<SteamGame> Games = new List<SteamGame>();

        public SteamLibrary(string path)
        {
            path = path.Replace("\\\\", "\\") + "\\SteamApps\\";
            Path = path;
            var files = Directory.EnumerateFiles(path, "*.acf", SearchOption.TopDirectoryOnly);
            ACFParser parser = new ACFParser();
            foreach (var file in files)
            {
                string[] tokens = parser.Parse(file).Split(',');
                if (tokens.Length == 3)
                {
                    SteamGame game = new SteamGame(tokens[0].Replace("\r\n", ""), path + "\\common\\" + tokens[1].Replace("\r\n", ""), Convert.ToInt32(tokens[2].Replace("\r\n", "")));
                    Games.Add(game);
                }
            }
        }
    }
}
