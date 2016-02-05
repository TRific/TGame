using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public void moveScenes(int num)
    {
        Debug.Log("Back was clicked");
        SceneManager.LoadScene(0);
    }
}
