using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        UnityEngine.Debug.Log("Game Closed");
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
