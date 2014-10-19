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
            this.btnSelect = new System.Windows.Forms.Button();
            this.lvwGames = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateShortcut = new System.Windows.Forms.Button();
            this.lblLibraryPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLibraryGames = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 124);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Open Library";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lvwGames
            // 
            this.lvwGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwGames.FullRowSelect = true;
            this.lvwGames.Location = new System.Drawing.Point(12, 159);
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
            this.btnCreateShortcut.Location = new System.Drawing.Point(14, 520);
            this.btnCreateShortcut.Name = "btnCreateShortcut";
            this.btnCreateShortcut.Size = new System.Drawing.Size(122, 25);
            this.btnCreateShortcut.TabIndex = 3;
            this.btnCreateShortcut.Text = "Create Shortcut";
            this.btnCreateShortcut.UseVisualStyleBackColor = true;
            this.btnCreateShortcut.Click += new System.EventHandler(this.btnCreateShortcut_Click);
            // 
            // lblLibraryPath
            // 
            this.lblLibraryPath.AutoSize = true;
            this.lblLibraryPath.Location = new System.Drawing.Point(3, 41);
            this.lblLibraryPath.Name = "lblLibraryPath";
            this.lblLibraryPath.Size = new System.Drawing.Size(83, 13);
            this.lblLibraryPath.TabIndex = 4;
            this.lblLibraryPath.Text = "Open A Library";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ctrl/shift click to select multiple items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLibraryGames);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLibraryPath);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 100);
            this.panel1.TabIndex = 6;
            // 
            // lblLibraryGames
            // 
            this.lblLibraryGames.AutoSize = true;
            this.lblLibraryGames.Location = new System.Drawing.Point(3, 68);
            this.lblLibraryGames.Name = "lblLibraryGames";
            this.lblLibraryGames.Size = new System.Drawing.Size(58, 13);
            this.lblLibraryGames.TabIndex = 5;
            this.lblLibraryGames.Text = ".................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Library";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateShortcut);
            this.Controls.Add(this.lvwGames);
            this.Controls.Add(this.btnSelect);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(823, 456);
            this.Name = "frmMain";
            this.Text = "SteamLibraryManager v0.1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListView lvwGames;
        private System.Windows.Forms.Button btnCreateShortcut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblLibraryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLibraryGames;
        private System.Windows.Forms.Label label2;
    }
}

