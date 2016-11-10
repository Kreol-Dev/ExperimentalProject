﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;
using Ionic.Zip;
using System.IO;
static class ItchDeploy
{
    static string AccountName = "Avras_Chismar";
    static string ChannelName = "windows";
    public static void OnProjectBuilt(string pathToPlayer)
    {
        try
        {

            var i = pathToPlayer.LastIndexOf('/');
            pathToPlayer = pathToPlayer.Substring(0, i+ 1);
            File.Delete("/butler_creds");
            File.Delete("/butler.exe");
            
            File.Move(pathToPlayer + "ExperimentalProject_Data/StreamingAssets/butler_creds", "/butler_creds");
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

            uploadProc.WaitForExit();
        }
        catch (Exception e)
        {
            UnityEngine.Debug.LogWarning(e);
        }
    }

        
}