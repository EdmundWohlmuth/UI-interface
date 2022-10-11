using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public UIManager UIManager;

    public void LoadGameplay()
    {
        SceneManager.LoadScene("Gameplay");
        UIManager.GameplayScreen();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        UIManager.MainMenuScreen();
    }

    public void ExitGame()
    {
        Debug.Log("Exited Game");
        Application.Quit(0);
    }
}
