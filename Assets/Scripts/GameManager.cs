using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UImanager;
    private UIManager UI;

    public GameObject Player;
    public FirstPersonController_Sam fpsController;

    // Start is called before the first frame update
    void Start()
    {
       UImanager = GameObject.Find("GameManager/UIManager");
       UI = UImanager.GetComponent<UIManager>();       
    }

    // Update is called once per frame
    void Update()
    {
        MenuState();
    }

    void MenuState()
    {
        switch (UI.currentState)
        {
            case UIManager.CurrentScreen._MainMenu:

                Time.timeScale = 1;
                UI.MainMenuScreen();
                break;

            case UIManager.CurrentScreen._Gameplay:

                if (fpsController == null) FindPlayer();                
                Time.timeScale = 1;
                UI.GameplayScreen();

                fpsController.canMove = true;
                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    UI.PasueScreen();
                }
                else if (Input.GetKeyDown(KeyCode.Home))
                {
                    UI.WinScreen();
                }
                else if (Input.GetKeyDown(KeyCode.End))
                {
                    UI.GameoverScreen();
                }

                break;

            case UIManager.CurrentScreen._Pause:

                Time.timeScale = 0;
                UI.PasueScreen();

                fpsController.canMove = false;
                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    UI.GameplayScreen();
                }

                break;

            case UIManager.CurrentScreen._Gameover:

                Time.timeScale = 0;
                fpsController.canMove = false;
                UI.GameoverScreen();

                break;

            case UIManager.CurrentScreen._Win:

                Time.timeScale = 1;
                fpsController.canMove = false;
                UI.WinScreen();

                break;

            case UIManager.CurrentScreen._Settings:

                Time.timeScale = 1;
                UI.SettingsScreen();

                break;

            case UIManager.CurrentScreen._Credits:

                Time.timeScale = 1;
                UI.CreditsSceen();

                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    UI.MainMenuScreen();
                }

                break;
        }
    }
    
    void FindPlayer()
    {
        Player = GameObject.Find("Player");
        fpsController = Player.GetComponent<FirstPersonController_Sam>();
    }
}
