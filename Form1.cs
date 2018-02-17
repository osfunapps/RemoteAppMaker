using RemoteAppMaker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteAppMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadProperties();
        }

        private void loadProperties()
        {
            prototypeRemotePathTB.Text = Settings.Default.prototypePath;
            newRemotePathTB.Text = Settings.Default.newRemotePath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();
            if (result == DialogResult.OK && outputFolderDialog.SelectedPath.Length > 0)
            {
                prototypeRemotePathTB.Text = TitleExporter(sender.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();
            if (result == DialogResult.OK && outputFolderDialog.SelectedPath.Length > 0)
            {
                newRemotePathTB.Text = TitleExporter(sender.ToString());
            }
        }


        private string TitleExporter(string fileLongStr)
        {
            return fileLongStr.ToString().Substring(fileLongStr.ToString().IndexOf("FileName: ") + 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveProperties();
            AppMakerCoordinator appMakerCoordinator = new AppMakerCoordinator();
            appMakerCoordinator.coordinate(prototypeRemotePathTB.Text.ToString(), newRemotePathTB.Text.ToString());
        }

        private void saveProperties()
        {
            Settings.Default.Upgrade();
            Settings.Default.prototypePath = prototypeRemotePathTB.Text;
            Settings.Default.newRemotePath = newRemotePathTB.Text;
            Settings.Default.Save();
        }

        private void outputFolderDialog_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
