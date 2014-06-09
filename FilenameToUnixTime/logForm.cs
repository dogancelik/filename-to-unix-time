using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilenameToUnixTime
{
    public partial class LogForm : Form
    {
        public List<Tuple<string, string>> LogList; 

        public LogForm()
        {
            InitializeComponent();
            LogList = new List<Tuple<string, string>>();
            UpdateLog();
        }

        private void logForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void checkLog_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLog();
        }

        private void UpdateLog()
        {
            textBox.Clear();

            bool isLogChecked = checkLog.Checked;
            bool isErrorChecked = checkError.Checked;

            foreach (var item in LogList)
            {
                if (isLogChecked && item.Item1 == "info")
                {
                   textBox.AppendText(item.Item2, Color.Green);  
                }

                if (isErrorChecked && item.Item1 == "error")
                {
                    textBox.AppendText(item.Item2, Color.Red);
                }
            }
        }

        public void AddLog(string type, string text)
        {
            LogList.Add(new Tuple<string, string>(type, text));
            UpdateLog();
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
            box.AppendText("\n");
        }
    }
}
