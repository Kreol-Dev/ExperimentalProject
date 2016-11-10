using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;
using Ionic.Zip;
using System.IO;
namespace Assets
{
    static class ItchDeploy
    {
        static string AccountName = "Avras_Chismar";
        static string ChannelName = "windows";
        public static void OnProjectBuilt(string pathToPlayer)
        {
            File.Delete("/butler_creds");
            File.Delete("/butler.exe");
            //File.Delete
            File.Move(pathToPlayer + "/ExperimentalProject_Data/butler_creds", "/butler_creds");
            File.Move(pathToPlayer + "ExperimentalProject_Data/StreamingAssets/butler.exe", "/butler.exe");

            string args = String.Format(" -i {0} push {1} {2}:{3}",
                "/butler_creds",
                "ExperimentalProject.zip",
                AccountName,
                ChannelName                                
                );
            ZipFile file = new ZipFile();
            file.AddDirectory(pathToPlayer);
            file.Save("ExperimentalProject.zip");

            System.Diagnostics.Process uploadProc = new System.Diagnostics.Process();
            uploadProc.StartInfo.FileName = "/butler.exe";
            uploadProc.StartInfo.Arguments = args;
            uploadProc.StartInfo.CreateNoWindow = false;
            uploadProc.StartInfo.UseShellExecute = false;
            uploadProc.Start();
        }

        
    }
    
}
