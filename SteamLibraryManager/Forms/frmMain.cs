using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;
using System.Text.RegularExpressions;

namespace SteamLibraryManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "Select A SteamApps Folder";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.SelectedPath;
                var files = Directory.EnumerateFiles(path, "*.acf", SearchOption.TopDirectoryOnly);
                lvwGames.Items.Clear();
                SteamLibrary library = new SteamLibrary(path);
                lblLibraryPath.Text = path;
                ACFParser parser = new ACFParser();
                foreach(var file in files)
                {
                    string[] tokens = parser.Parse(file).Split(',');
                    if (tokens.Length == 3)
                    {
                        SteamGame game = new SteamGame(tokens[0].Replace("\r\n", ""), library.Path + "\\common\\" + tokens[1].Replace("\r\n", ""), Convert.ToInt32(tokens[2].Replace("\r\n", "")));
                        library.Games.Add(game);
                        GameItem item = new GameItem(game);
                        lvwGames.Items.Add(item);
                    }
                }
                lblLibraryGames.Text = "Games Found: " + library.Games.Count + ".";
            }
        }

        private void btnCreateShortcut_Click(object sender, EventArgs e)
        {
            if (lvwGames.SelectedItems.Count == 0)
                return;

            foreach(GameItem item in lvwGames.SelectedItems)
            {
                string name = item.Game.Name;
                if(name.Contains("/") || name.Contains("\\"))
                {
                    name = Path.GetFileName(item.Game.Path);
                }
                name = name.Replace(":", " ");
                name = Regex.Replace(name, @"[^\u0000-\u007F]", string.Empty);
                string shortcutLocation = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name + ".lnk");
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

                shortcut.Description = "SteamLibraryManager";
                shortcut.TargetPath = "steam://rungameid/" + item.Game.AppID;

                shortcut.Save(); 
            }
        }
    }
}
