using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Canvas MainMenu;
    public Canvas Gameplay;
    public Canvas Pause;
    public Canvas Gameover;
    public Canvas Win;

    enum CurrentScreen
    {
        _MainMenu,
        _Gameplay,
        _Pause,
        _Gameover,
        _Win,
    }
    CurrentScreen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuScreen();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentScreen)
        {
            case CurrentScreen._MainMenu:

                break;

            case CurrentScreen._Gameplay:
                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    PasueScreen();
                }
                else if (Input.GetKeyDown(KeyCode.W))
                {
                    WinScreen();
                }
                else if (Input.GetKeyDown(KeyCode.L))
                {
                    GameoverScreen();
                }
                break;

            case CurrentScreen._Pause:
                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    GameplayScreen();
                }
                break;

            case CurrentScreen._Gameover:

                break;

            case CurrentScreen._Win:

                break;
        }
    }

    public void MainMenuScreen()
    {
        Time.timeScale = 1;

        MainMenu.enabled = true;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;

        currentScreen = CurrentScreen._MainMenu;
    }

    public void GameplayScreen()
    {
        Time.timeScale = 1;

        MainMenu.enabled = false;
        Gameplay.enabled = true;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;

        currentScreen = CurrentScreen._Gameplay;
    }

    public void PasueScreen()
    {
        Time.timeScale = 0;

        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = true;
        Gameover.enabled = false;
        Win.enabled = false;

        currentScreen = CurrentScreen._Pause;
    }

    public void GameoverScreen()
    {
        Time.timeScale = 0;

        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = true;
        Win.enabled = false;

        currentScreen = CurrentScreen._Gameover;
    }

    public void WinScreen()
    {
        Time.timeScale = 1;

        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = true;

        currentScreen = CurrentScreen._Win;
    }
}
