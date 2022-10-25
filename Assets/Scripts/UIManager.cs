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

    public enum CurrentScreen
    {
        _MainMenu,
        _Gameplay,
        _Pause,
        _Gameover,
        _Win,
        _Settings,
        _Credits
    }
    public CurrentScreen currentState;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuScreen();
    }


    public void MainMenuScreen()
    {
        MainMenu.enabled = true;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;
        Settings.enabled = false;
        Credits.enabled = false;

        currentState = CurrentScreen._MainMenu;
    }

    public void GameplayScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = true;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;
        Settings.enabled = false;
        Credits.enabled = false;

        currentState = CurrentScreen._Gameplay;
    }

    public void PasueScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = true;
        Gameover.enabled = false;
        Win.enabled = false;
        Settings.enabled = false;
        Credits.enabled = false;

        currentState = CurrentScreen._Pause;
    }

    public void GameoverScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = true;
        Win.enabled = false;
        Settings.enabled = false;
        Credits.enabled = false;

        currentState = CurrentScreen._Gameover;
    }

    public void WinScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = true;
        Settings.enabled = false;
        Credits.enabled = false;

        currentState = CurrentScreen._Win;
    }

    public void SettingsScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;
        Settings.enabled = true;
        Credits.enabled = false;

        currentState = CurrentScreen._Settings;
    }

    public void CreditsSceen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;
        Settings.enabled = false;
        Credits.enabled = true;

        currentState = CurrentScreen._Credits;
    }
}
