using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RadiantLauncher : MonoBehaviour
{
 
    public void LaunchGenshin()
    {
        Process.Start("C:/Program Files/Genshin Impact/Genshin Impact Game/GenshinImpact.exe");
    }
    
    public void LaunchHonkai()
    {
        Process.Start("C:/Program Files/Honkai Impact 3rd glb/Games/BH3.exe");
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