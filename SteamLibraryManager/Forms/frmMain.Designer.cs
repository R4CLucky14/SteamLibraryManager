namespace SteamLibraryManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lvwGames = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateShortcut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLibraries = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwGames
            // 
            this.lvwGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwGames.FullRowSelect = true;
            this.lvwGames.Location = new System.Drawing.Point(12, 61);
            this.lvwGames.Name = "lvwGames";
            this.lvwGames.Size = new System.Drawing.Size(782, 311);
            this.lvwGames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwGames.TabIndex = 2;
            this.lvwGames.UseCompatibleStateImageBehavior = false;
            this.lvwGames.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game";
            this.columnHeader1.Width = 269;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 505;
            // 
            // btnCreateShortcut
            // 
            this.btnCreateShortcut.Location = new System.Drawing.Point(12, 404);
            this.btnCreateShortcut.Name = "btnCreateShortcut";
            this.btnCreateShortcut.Size = new System.Drawing.Size(122, 25);
            this.btnCreateShortcut.TabIndex = 3;
            this.btnCreateShortcut.Text = "Create Shortcut";
            this.btnCreateShortcut.UseVisualStyleBackColor = true;
            this.btnCreateShortcut.Click += new System.EventHandler(this.btnCreateShortcut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ctrl/shift click to select multiple items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLibraries);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 43);
            this.panel1.TabIndex = 6;
            // 
            // cbLibraries
            // 
            this.cbLibraries.FormattingEnabled = true;
            this.cbLibraries.Location = new System.Drawing.Point(3, 10);
            this.cbLibraries.Name = "cbLibraries";
            this.cbLibraries.Size = new System.Drawing.Size(773, 21);
            this.cbLibraries.TabIndex = 1;
            this.cbLibraries.SelectedValueChanged += new System.EventHandler(this.cbLibraries_SelectedValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateShortcut);
            this.Controls.Add(this.lvwGames);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(823, 456);
            this.Name = "frmMain";
            this.Text = "SteamLibraryManager v0.1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwGames;
        private System.Windows.Forms.Button btnCreateShortcut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLibraries;
    }
}

