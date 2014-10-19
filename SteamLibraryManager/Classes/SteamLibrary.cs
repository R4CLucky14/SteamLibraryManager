using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamLibraryManager
{
    public class SteamLibrary
    {
        private string _path;
        public string Path { get { return _path; } set { this._path = value; } }
        public List<SteamGame> Games = new List<SteamGame>();

        public SteamLibrary(string path)
        {
            Path = path;
        }

        public void AddGame(string name, string path, int appid)
        {
            Games.Add(new SteamGame(name, path, appid));
        }
    }
}
