using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamLibraryManager
{
    public class SteamGame
    {
        private string _name, _path;
        private int _appid;

        public string Name { get { return _name; } set { this._name = value; } }
        public string Path { get { return _path; } set { this._path = value; } }
        public int AppID { get { return _appid; } set { this._appid = value; } }

        public SteamGame(string name, string path, int appid)
        {
            Name = name;
            Path = path;
            AppID = appid;
        }
    }
}
