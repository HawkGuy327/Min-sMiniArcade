using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadPong()
    {
        SceneManager.LoadScene("Pong");
    }
    public void LoadMashingGame()
    {
        SceneManager.LoadScene("MashingGame");
    }
    public void LoadEndlessRunner()
    {
        SceneManager.LoadScene("EndlessRunner");
    }
    public void LoadPlatformerRace()
    {
        SceneManager.LoadScene("PlatformerRace");
    }
    public void LoadTag()
    {
        SceneManager.LoadScene("Tag");
    }
    public void LoadSmallTrackRacer()
    {
        SceneManager.LoadScene("SmallTrackRacer");
    }
    public void LoadTanksGame()
    {
        SceneManager.LoadScene("TanksGame");
    }
}
