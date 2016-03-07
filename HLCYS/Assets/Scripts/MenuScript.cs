using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    //Menu Sates
    public enum MenuStates{ Main,Options,Highscore};
    public MenuStates currentstate;
    
    //Menu Panel Objects
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject HighscoreMenu;


    //When script first starts
    void Awake()
    {
        //always sets first menu to main menu
        currentstate = MenuStates.Main;
    }

    void Update()
    {
        //checks current menu state
        switch (currentstate)
        {
            case MenuStates.Main:
                //set active gameobjects for main menu
                mainMenu.SetActive(true);
                optionsMenu.SetActive(false);
                HighscoreMenu.SetActive(false);
                break;
            case MenuStates.Options:
                //set active gameobjects for main menu
                mainMenu.SetActive(false);
                optionsMenu.SetActive(true);
                HighscoreMenu.SetActive(false);
                break;

            case MenuStates.Highscore:
                //set active gameobjects for main menu
                mainMenu.SetActive(false);
                optionsMenu.SetActive(false);
                HighscoreMenu.SetActive(true);
                break;

        }
    }



   public void OnStartGame()
    {
        Debug.Log("You pressed Start Game");
        SceneManager.LoadScene("NewGamePage");
		//BoxScriptV2Test.player_is_dead = false;
		BoxSwingScriptV2.player_is_dead = false;
    }

    public void OnOptions()
    {
        Debug.Log("You pressed Options");

        currentstate = MenuStates.Options;
    }
    public void OnExitGame()
    {
        Debug.Log("You pressed Exit Game");
        Application.Quit();
    }
    public void OnBack()
    {
        Debug.Log("You pressed back to Main Menu");
        currentstate = MenuStates.Main;
    }
    public void OnHighScore()
    {
        Debug.Log("You pressed Highscore");
        currentstate = MenuStates.Highscore;
    }

}
