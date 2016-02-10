using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {
    public enum pauseStates { Pause, NotPause};
    public pauseStates currentstate;

    //Menu Panel Objects
    public GameObject pauseMenu;
    public GameObject nopauseMenu;
    public GameObject theBox;

    // Use this for initialization
    void Awake () {
        currentstate = pauseStates.NotPause;
    }
	
	// Update is called once per frame
	void Update () {
        switch (currentstate)
        {
            case pauseStates.NotPause:
                //set active gameobjects for main menu
                nopauseMenu.SetActive(true);
                pauseMenu.SetActive(false);
                theBox.SetActive(true);
                break;
            case pauseStates.Pause:
                //set active gameobjects for main menu
                nopauseMenu.SetActive(false);
                pauseMenu.SetActive(true);
                theBox.SetActive(false);
                break;
        }
    }

    public void OnPauseGame()
    {
        Debug.Log("You pressed Pause");
        currentstate = pauseStates.Pause;

    }

    public void OnUnpauseGame()
    {
        Debug.Log("You pressed Unpause");
        currentstate = pauseStates.NotPause;

    }

    public void OnMainMenuGame()
    {
        Debug.Log("You pressed Pause");   
        SceneManager.LoadScene("NewTitlePage");

    }
}
