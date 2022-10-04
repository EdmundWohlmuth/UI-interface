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
    public Canvas Credits;
    public Canvas Settings;

    enum CurrentScreen
    {
        _MainMenu,
        _Gameplay,
        _Pause,
        _Gameover,
        _Win,
        _Settings,
        _Credits
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
                MainMenuScreen();
                break;

            case CurrentScreen._Gameplay:

                GameplayScreen();

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

                PasueScreen();

                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    GameplayScreen();
                }

                break;

            case CurrentScreen._Gameover:

                GameoverScreen();

                break;

            case CurrentScreen._Win:

                WinScreen();

                break;

            case CurrentScreen._Settings:

                SettingsScreen();

                break;

            case CurrentScreen._Credits:

                CreditsSceen();

                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    MainMenuScreen();
                }

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
        Settings.enabled = false;
        Credits.enabled = false;

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
        Settings.enabled = false;
        Credits.enabled = false;

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
        Settings.enabled = false;
        Credits.enabled = false;

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
        Settings.enabled = false;
        Credits.enabled = false;

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
        Settings.enabled = false;
        Credits.enabled = false;

        currentScreen = CurrentScreen._Win;
    }

    public void SettingsScreen()
    {
        Time.timeScale = 1;

        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;
        Settings.enabled = true;
        Credits.enabled = false;

        currentScreen = CurrentScreen._Settings;
    }

    public void CreditsSceen()
    {
        Time.timeScale = 1;

        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;
        Settings.enabled = false;
        Credits.enabled = true;

        currentScreen = CurrentScreen._Credits;
    }
}
