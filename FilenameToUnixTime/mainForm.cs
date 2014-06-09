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
using System.Diagnostics;

namespace FilenameToUnixTime
{
    public partial class MainForm : Form
    {
        private HashSet<string> _files;
        private LogForm logForm;

        public MainForm()
        {
            InitializeComponent();
            _files = new HashSet<string>();
            logForm = new LogForm();
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderDialog.SelectedPath);
                addFilesToList(files);
            }
        }

        private void filesButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = fileDialog.FileNames;
                addFilesToList(files);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _files.Clear();
            listView.Items.Clear();
        }

        private void addFilesToList(string[] files)
        {
            for (int i = 0; i < files.Length; i++)
            {
                _files.Add(files[i]);
                Debug.WriteLine("File: {0}", new[] { files[i] });
                Debug.WriteLine("_files: {0}", new[] { _files.Count.ToString() });
            }

            listView.Items.Clear();
            listView.BeginUpdate();
            
            var arr = _files.ToArray();
            for (int i = 0;  i < arr.Length; i++)
            {
                Debug.WriteLine("File: " + arr[i]);
                Debug.WriteLine("Exist: " + File.Exists(arr[i]).ToString());

                if (File.Exists(arr[i]))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = arr[i];
                    item.SubItems.Add(GetUnixFilename(arr[i]));
                    item.SubItems.Add("Ready");
                    listView.Items.Add(item);
                }
                else
                {
                    _files.Remove(arr[i]);
                }
                
            }

            listView.EndUpdate();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private static string GetUnixTime(string file)
        {
            var unixDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var writeDate = new FileInfo(file).LastWriteTimeUtc;
            var spanDate = writeDate - unixDate;

            return Math.Truncate(spanDate.TotalMilliseconds).ToString();
        }

        private static string GetUnixFilename(string file, bool includePath = false)
        {
            string unixfile = GetUnixTime(file) + Path.GetExtension(file);

            return (includePath ? Path.Combine(Path.GetDirectoryName(file), unixfile) : unixfile);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                var file = listView.Items[i].Text;

                try
                {
                    string oldFilename = file;
                    string newFildname = GetUnixFilename(file, true);
                    
                    Debug.WriteLine("Old: " + oldFilename);
                    Debug.WriteLine("New: " + newFildname);

                    File.Move(oldFilename, newFildname);
                    listView.Items[i].SubItems[2].Text = "OK";

                    logForm.AddLog("info", String.Format("Renamed '{0}' to '{1}'", oldFilename, newFildname));
                } 
                catch (Exception ex)
                {
                    listView.Items[i].SubItems[2].Text = ex.Message;
                    logForm.AddLog("error", String.Format("'{0}' could not be renamed because '{1}'", file, ex.Message));
                }
            }

            buttonRevert.Enabled = true;
        }

        private static string ReplaceFilename(string oldFilename, string newFilename)
        {
            return Path.Combine(Path.GetDirectoryName(oldFilename), newFilename);
        }


        private void revertButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                var file = listView.Items[i].Text;

                if (listView.Items[i].SubItems[2].Text == "OK")
                {
                    Debug.WriteLine("Revert: " + ReplaceFilename(file, listView.Items[i].SubItems[1].Text));

                    var newFilename = ReplaceFilename(file, listView.Items[i].SubItems[1].Text);
                    var oldFilename = Path.GetFileName(file);

                    try
                    {
                        File.Move(newFilename, file);
                        listView.Items[i].SubItems[2].Text = "Reverted";
                        logForm.AddLog("info", String.Format("Reverted '{0}' to '{1}'", newFilename, oldFilename));
                    }
                    catch (Exception ex)
                    {
                        listView.Items[i].SubItems[2].Text = ex.Message;
                        logForm.AddLog("error", String.Format("'{0}' could not be renamed because '{1}'", file, ex.Message));
                    }
                }
            }

            buttonRevert.Enabled = false;
        }

        private void mainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void mainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            addFilesToList(files);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            logForm.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }
    }
}
