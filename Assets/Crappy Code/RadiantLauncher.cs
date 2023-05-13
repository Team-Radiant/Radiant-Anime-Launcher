using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using Steamworks;

public class RadiantLauncher : MonoBehaviour
{    
    public void LaunchGenshin()
    {
        Process.Start("C:/Program Files/Genshin Impact/Genshin Impact Game/GenshinImpact.exe");
    }
    
    public void LaunchHonkai()
    {
        string honkaiExePath = @"C:\Program Files\Honkai Impact 3rd glb\Games\BH3.exe";

                if (SteamManager.Initialized)
        {
            AppId_t appId = new AppId_t(1671200);
            uint folderSize = 1024;
            string steamInstallPath = null;
            SteamApps.GetAppInstallDir(appId, out steamInstallPath, folderSize);
            
            if (!string.IsNullOrEmpty(steamInstallPath))
            {
                string honkaiSteamPath = Path.Combine(steamInstallPath, "steamapps/common/Honkai Impact 3rd/BH3.exe");
                if (File.Exists(honkaiSteamPath))
                {
                    Process.Start(honkaiSteamPath);
                    return;
                }
            }
        }

        Process.Start(honkaiExePath);
    }

    public void LaunchStarRail()
    {
        Process.Start("C:/Program Files/Star Rail/Games/StarRail.exe");
    }

    public void GenshinScene()
    {
        SceneManager.LoadScene("Genshin");
    }

    public void HonkaiScene()
    {
        SceneManager.LoadScene("Honkai");
    }

    public void StarRailScene()
    {
        SceneManager.LoadScene("StarRail");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("RadiantLauncherRewrite");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Creds");
    }
}