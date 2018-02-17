using System;
using System.IO;
using System.Windows.Forms;

namespace RemoteAppMaker
{
    internal class AssetsFilesHandler
    {
        internal void switchAssetsFiles(string prototypePath, string newRemotePath)
        {
            //new remote resources
            FileInfo[] pngFilesSrcs = new DirectoryInfo(newRemotePath).GetFiles("*.png", SearchOption.AllDirectories);


            //prototype remote resources
            String appFolderPath = Directory.GetDirectories(prototypePath, "app")[0];
            String srcFolderPath = Directory.GetDirectories(appFolderPath, "src")[0];
            String mainFolderPath = Directory.GetDirectories(srcFolderPath, "main")[0];
            String assetsFolderPath = Directory.GetDirectories(mainFolderPath, "assets")[0];
            String remotesAssetsPath = assetsFolderPath + "\\remotes";

            //remove the remotes assets folder


            Directory.Delete(@remotesAssetsPath, true);

            //create new remotes assets folder
            Directory.CreateDirectory(remotesAssetsPath);

            foreach(FileInfo file in pngFilesSrcs)
            {
                if (file.Name.Equals("logo.png") || file.Name.Equals("remote.png")) continue;
                File.Copy(file.FullName, remotesAssetsPath + "\\"+file.Name);
            }

            MessageBox.Show("All done!");
        }
    }
}