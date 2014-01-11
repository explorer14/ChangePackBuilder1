#region About
/*
 * Written By: Aman Agrawal
 * First Created On : 15-October-2013
 */
#endregion
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;

namespace ChangePackBuilder
{
    public partial class frmChangePackBuilder : Form
    {
        private string destinationFolder;
        private List<string> allowedFileTypes;
        private List<string> ignoredPaths;
        List<string> changedFiles;

        public frmChangePackBuilder()
        {
            InitializeComponent();            
            string fileTypesString = ConfigurationManager.AppSettings["SupportedFileTypes"];
            string ignoredPathString = ConfigurationManager.AppSettings["IgnoredPaths"];
            allowedFileTypes = fileTypesString.Split(new char[] { ',' }, StringSplitOptions.None).ToList();
            ignoredPaths = ignoredPathString.Split(new char[] { ',' }, StringSplitOptions.None).ToList();
            changedFiles = new List<string>();                        
        }
                
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            btnMonitor.Enabled = false;
            changeTracker.Changed += new System.IO.FileSystemEventHandler(changeTracker_Changed);            
        }        

        void changeTracker_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (!changeList.Items.Contains(e.FullPath))
            {
                changeList.Items.Add(e.FullPath);
            }            
        }

        private void btnBuildReleasePack_Click(object sender, EventArgs e)
        {                                   
            //lets pull items out into a list so we can use LINQ and lamdas
            changedFiles.Clear();

            foreach (string item in changeList.Items)
            {
                changedFiles.Add(item);
            }

            try
            {
                //prefix the ignored paths with the path we are monitoring since the project root may vary from machine to machine but
                //the project folder structure won't and we need to do an exact match against the ignore list
                ignoredPaths = ignoredPaths.Select(x => txtPathToMonitor.Text + x).ToList();
                //lets filter out any non-allowed files that might be created/edited/deleted as a result of me changing the files
                changedFiles = changedFiles.Where(x => allowedFileTypes.Contains(Path.GetExtension(x))).Select(x => x.Split(new char[] { '~' })[0]).ToList();

                foreach (string filePath in changedFiles)
                {
                    //dont include any obj, bin or client bin folders as these are runtime folders, also ignore anything in the ignored list
                    if (!(filePath.Contains("obj") || filePath.Contains("bin") || filePath.Contains("ClientBin") || ignoredPaths.Contains(filePath)))
                    {                                          
                        //remove the project root path from the folder string coz I am just interested in the project folders
                        //for e.g. if the file path is c:\projects\project1\BLL\DataManager.cs, i want to replicate the folder structure
                        //BLL onwards so I need to remove the root i.e. c:\projects\project1 and then split out the individual folders                        
                        string finalDest = destinationFolder + Path.GetDirectoryName(filePath).Replace(txtPathToMonitor.Text, "");
                        Directory.CreateDirectory(finalDest);
                        File.Copy(filePath, finalDest + "\\" + Path.GetFileName(filePath), true);
                    }
                }

                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
            }
            finally
            {
                btnMonitor.Enabled = true;
                btnStopMonitoring_Click(this, EventArgs.Empty);
            }            
        }

        private void btnSelectPathToMonitor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == ReleaseFolderBrowser.ShowDialog())
            {
                txtPathToMonitor.Text = ReleaseFolderBrowser.SelectedPath;
                changeTracker.Path = txtPathToMonitor.Text;
            }
        }

        private void btnBrowseToReleaseDestination_Click(object sender, EventArgs e)
        {
            //fixed a bug here where, once the release folder was set the folder browser didn't open again even if you
            //wanted to change the path.
            if (DialogResult.OK == ReleaseFolderBrowser.ShowDialog())
            {
                destinationFolder = ReleaseFolderBrowser.SelectedPath;
                txtReleaseDestination.Text = destinationFolder;
            }         
        }

        private void frmReleaseBuilder_Load(object sender, EventArgs e)
        {
            this.Text += Application.ProductVersion;            
        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {            
            changeTracker.Changed -= new System.IO.FileSystemEventHandler(changeTracker_Changed);
            btnMonitor.Enabled = true;
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            changeList.Items.Clear();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changeList.SelectedItems.Count > 0)
            {
                //allow multiple selects and deletes
                int itemCount = changeList.SelectedIndices.Count;

                for (int i = 0; i < itemCount; i++)
                {
                    changeList.Items.RemoveAt(changeList.SelectedIndex);
                }                                
            }            
        }
    }
}
