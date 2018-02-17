using System;

namespace RemoteAppMaker
{
    internal class AppMakerCoordinator
    {
        internal void coordinate(string prototypePath, string newRemotePath)
        {
            new StringsFileHandler().switchStringsFile(prototypePath, newRemotePath);
            new LogoFileHandler().switchLogoFile(prototypePath, newRemotePath);
            new AssetsFilesHandler().switchAssetsFiles(prototypePath, newRemotePath);
        }
    }
}