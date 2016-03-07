using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {
    public enum pauseStates { Pause, NotPause};
    public pauseStates currentstate;
    public bool paused;

    //Menu Panel Objects
    public GameObject pauseMenu;
    public GameObject nopauseMenu;
    //public GameObject thePlayer;
    public GameObject GAMEOVER_MENU;

    // Use this for initialization
    void Awake () {
        currentstate = pauseStates.NotPause;
        paused = false;
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        switch (currentstate)
        {
            case pauseStates.NotPause:
                //set active gameobjects for main menu
                nopauseMenu.SetActive(true);
                pauseMenu.SetActive(false);
                GAMEOVER_MENU.SetActive(false);
                //theBox.SetActive(true);
                break;
            case pauseStates.Pause:
                //set active gameobjects for main menu
                nopauseMenu.SetActive(false);
                pauseMenu.SetActive(true);
                GAMEOVER_MENU.SetActive(false);
                //theBox.SetActive(false);
                break;
         
        }
    }

    public void OnPauseGame()
    {
        Debug.Log("You pressed Pause");
        currentstate = pauseStates.Pause;
        Time.timeScale = 0;
        paused = true;

    }

    public void OnUnpauseGame()
    {
        Debug.Log("You pressed Unpause");
        currentstate = pauseStates.NotPause;
        Time.timeScale = 1;
        paused = false;
    }

    public void OnMainMenuGame()
    {
        Debug.Log("You pressed Pause");   
        SceneManager.LoadScene("NewTitlePage");
        SceneManager.UnloadScene("NewGamePage");
        Time.timeScale = 1;
        paused = false;
    }

	public void OnRestartGame()
	{
		nopauseMenu.SetActive(true);
		pauseMenu.SetActive(false);
		GAMEOVER_MENU.SetActive(false);
		Debug.Log("You pressed Start Game");
		SceneManager.LoadScene("NewGamePage");
		//BoxScriptV2Test.player_is_dead = false;
		BoxSwingScriptV2.player_is_dead = false;//for andriod swipe
	}
}
