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

                break;

            case CurrentScreen._Pause:

                break;

            case CurrentScreen._Gameover:

                break;

            case CurrentScreen._Win:

                break;
        }
    }

    public void MainMenuScreen()
    {
        MainMenu.enabled = true;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;
    }

    public void GameplayScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = true;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = false;
    }

    public void PasueScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = true;
        Gameover.enabled = false;
        Win.enabled = true;
    }

    public void GameoverScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = true;
        Win.enabled = false;
    }

    public void WinScreen()
    {
        MainMenu.enabled = false;
        Gameplay.enabled = false;
        Pause.enabled = false;
        Gameover.enabled = false;
        Win.enabled = true;
    }
}
