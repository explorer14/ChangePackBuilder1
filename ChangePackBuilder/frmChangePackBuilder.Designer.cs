namespace ChangePackBuilder
{
    partial class frmChangePackBuilder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePackBuilder));
            this.changeTracker = new System.IO.FileSystemWatcher();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.changeList = new System.Windows.Forms.ListBox();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuildReleasePack = new System.Windows.Forms.Button();
            this.ReleaseFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPathToMonitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPathToMonitor = new System.Windows.Forms.Button();
            this.btnBrowseToReleaseDestination = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReleaseDestination = new System.Windows.Forms.TextBox();
            this.btnStopMonitoring = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.changeTracker)).BeginInit();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeTracker
            // 
            this.changeTracker.EnableRaisingEvents = true;
            this.changeTracker.IncludeSubdirectories = true;
            this.changeTracker.SynchronizingObject = this;
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(16, 349);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(118, 23);
            this.btnMonitor.TabIndex = 0;
            this.btnMonitor.Text = "Start Monitoring";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // changeList
            // 
            this.changeList.ContextMenuStrip = this.rightClickMenu;
            this.changeList.FormattingEnabled = true;
            this.changeList.HorizontalScrollbar = true;
            this.changeList.Location = new System.Drawing.Point(13, 44);
            this.changeList.Name = "changeList";
            this.changeList.Size = new System.Drawing.Size(630, 225);
            this.changeList.TabIndex = 1;
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // btnBuildReleasePack
            // 
            this.btnBuildReleasePack.Location = new System.Drawing.Point(264, 349);
            this.btnBuildReleasePack.Name = "btnBuildReleasePack";
            this.btnBuildReleasePack.Size = new System.Drawing.Size(118, 23);
            this.btnBuildReleasePack.TabIndex = 2;
            this.btnBuildReleasePack.Text = "Build Change Pack";
            this.btnBuildReleasePack.UseVisualStyleBackColor = true;
            this.btnBuildReleasePack.Click += new System.EventHandler(this.btnBuildReleasePack_Click);
            // 
            // txtPathToMonitor
            // 
            this.txtPathToMonitor.Location = new System.Drawing.Point(126, 278);
            this.txtPathToMonitor.Name = "txtPathToMonitor";
            this.txtPathToMonitor.ReadOnly = true;
            this.txtPathToMonitor.Size = new System.Drawing.Size(299, 20);
            this.txtPathToMonitor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path to Monitor:";
            // 
            // btnSelectPathToMonitor
            // 
            this.btnSelectPathToMonitor.Location = new System.Drawing.Point(431, 277);
            this.btnSelectPathToMonitor.Name = "btnSelectPathToMonitor";
            this.btnSelectPathToMonitor.Size = new System.Drawing.Size(36, 23);
            this.btnSelectPathToMonitor.TabIndex = 5;
            this.btnSelectPathToMonitor.Text = "...";
            this.btnSelectPathToMonitor.UseVisualStyleBackColor = true;
            this.btnSelectPathToMonitor.Click += new System.EventHandler(this.btnSelectPathToMonitor_Click);
            // 
            // btnBrowseToReleaseDestination
            // 
            this.btnBrowseToReleaseDestination.Location = new System.Drawing.Point(431, 303);
            this.btnBrowseToReleaseDestination.Name = "btnBrowseToReleaseDestination";
            this.btnBrowseToReleaseDestination.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseToReleaseDestination.TabIndex = 8;
            this.btnBrowseToReleaseDestination.Text = "...";
            this.btnBrowseToReleaseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseToReleaseDestination.Click += new System.EventHandler(this.btnBrowseToReleaseDestination_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Release Destination :";
            // 
            // txtReleaseDestination
            // 
            this.txtReleaseDestination.Location = new System.Drawing.Point(126, 304);
            this.txtReleaseDestination.Name = "txtReleaseDestination";
            this.txtReleaseDestination.ReadOnly = true;
            this.txtReleaseDestination.Size = new System.Drawing.Size(299, 20);
            this.txtReleaseDestination.TabIndex = 6;
            // 
            // btnStopMonitoring
            // 
            this.btnStopMonitoring.Location = new System.Drawing.Point(140, 349);
            this.btnStopMonitoring.Name = "btnStopMonitoring";
            this.btnStopMonitoring.Size = new System.Drawing.Size(118, 23);
            this.btnStopMonitoring.TabIndex = 9;
            this.btnStopMonitoring.Text = "Stop Monitoring";
            this.btnStopMonitoring.UseVisualStyleBackColor = true;
            this.btnStopMonitoring.Click += new System.EventHandler(this.btnStopMonitoring_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(525, 276);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(118, 23);
            this.btnClearList.TabIndex = 10;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Changed Files";
            // 
            // frmChangePackBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnStopMonitoring);
            this.Controls.Add(this.btnBrowseToReleaseDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReleaseDestination);
            this.Controls.Add(this.btnSelectPathToMonitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathToMonitor);
            this.Controls.Add(this.btnBuildReleasePack);
            this.Controls.Add(this.changeList);
            this.Controls.Add(this.btnMonitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePackBuilder";
            this.Text = "ChangePackBuilder ver ";
            this.Load += new System.EventHandler(this.frmReleaseBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.changeTracker)).EndInit();
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher changeTracker;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.ListBox changeList;
        private System.Windows.Forms.Button btnBuildReleasePack;
        private System.Windows.Forms.FolderBrowserDialog ReleaseFolderBrowser;
        private System.Windows.Forms.Button btnSelectPathToMonitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathToMonitor;
        private System.Windows.Forms.Button btnBrowseToReleaseDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReleaseDestination;
        private System.Windows.Forms.Button btnStopMonitoring;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

