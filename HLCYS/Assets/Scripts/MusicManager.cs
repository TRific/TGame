using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour {
    
    bool BGM;

    void Awake()
    {
        BGM = false;
           
    }

    void Update()
    {
        if (BGM == false)
        {
            AudioListener.volume = 0.5f;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }

    public void BGMToggle()
    {
        if(BGM == false)
        {
            BGM = true;
        }
        else
        {
            BGM = false;
        }
    }

}
