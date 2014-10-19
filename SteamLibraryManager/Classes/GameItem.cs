using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamLibraryManager
{
    public class GameItem : ListViewItem
    {
        public SteamGame Game;
        public GameItem(SteamGame game)
        {
            Game = game;

            this.Text = game.Name;
            this.SubItems.Add(game.Path);
        }
    }
}
