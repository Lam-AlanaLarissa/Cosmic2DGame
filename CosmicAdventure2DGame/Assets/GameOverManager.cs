using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class GameOverManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        UnityEngine.Debug.Log("Quit Game");
    }

    public void Restart()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}
