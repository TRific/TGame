using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class changeScene : MonoBehaviour {

    public void ChangeToScene (string name)
        {
        SceneManager.LoadScene(name);
        }
}
