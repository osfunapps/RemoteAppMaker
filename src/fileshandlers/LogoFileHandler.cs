using System;
using System.IO;

namespace RemoteAppMaker
{
    internal class LogoFileHandler
    {

        internal void switchLogoFile(string prototypePath, string newRemotePath)
        {
            //new remote resources
            FileInfo logoFileSrc = new DirectoryInfo(newRemotePath).GetFiles("logo.png", SearchOption.AllDirectories)[0];


            //prototype remote resources
            String appFolderPath = Directory.GetDirectories(prototypePath, "app")[0];
            String srcFolderPath = Directory.GetDirectories(appFolderPath, "src")[0];
            String mainFolderPath = Directory.GetDirectories(srcFolderPath, "main")[0];
            FileInfo logoFileDest = new DirectoryInfo(mainFolderPath).GetFiles("logo.png", SearchOption.AllDirectories)[0];

            File.Copy(logoFileSrc.FullName, logoFileDest.FullName, true);

        }
    }
}