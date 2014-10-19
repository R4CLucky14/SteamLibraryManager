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
using System.Threading;

namespace SteamLibraryManager
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            try
            {
                InitializeComponent();

                new Thread(new ThreadStart(delegate
                {
                    Global.Instance.FindSteamLibraries();

                    foreach (SteamLibrary library in Global.Instance.Libraries)
                    {
                        InvokeCB(library.Path);
                    }
                })).Start();
            } 
            catch(SteamNotFoundException ex)
            {
                if(MessageBox.Show(this, "Steam is not installed on your computer.", "SteamLibraryManager") == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void InvokeCB(string path)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { InvokeCB(path); }));
            }
            else
            { 
                cbLibraries.Items.Add(path);
                cbLibraries.SelectedValue = path;
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

        private void cbLibraries_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbLibraries.SelectedIndex != -1)
            {
                lvwGames.Items.Clear();
                string value = ((string)cbLibraries.Items[cbLibraries.SelectedIndex]);
                if (value == null) return;

                SteamLibrary library = Global.Instance.Libraries.Find(lib => lib.Path == value);
                foreach(SteamGame game in library.Games)
                {
                    lvwGames.Items.Add(new GameItem(game));
                }
            }
        }
    }
}
