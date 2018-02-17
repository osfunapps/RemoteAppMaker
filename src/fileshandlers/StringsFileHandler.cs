using System;
using System.IO;

namespace RemoteAppMaker
{
    internal class StringsFileHandler
    {
        internal void switchStringsFile(string prototypePath, string newRemotePath)
        {

            //new remote resources
            FileInfo stringsXmlFileSrc = new DirectoryInfo(newRemotePath).GetFiles("strings.xml", SearchOption.AllDirectories)[0];


            //prototype remote resources
            String appFolderPath = Directory.GetDirectories(prototypePath, "app")[0];
            FileInfo stringsXmlFileDest = new DirectoryInfo(appFolderPath).GetFiles("strings.xml", SearchOption.AllDirectories)[0];

            File.Copy(stringsXmlFileSrc.FullName, stringsXmlFileDest.FullName, true);
        }
    }
}