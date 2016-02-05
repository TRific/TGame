using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class changePanel : MonoBehaviour {
    private GameObject titlePanel;
    private GameObject optionPanel;

  
    void Start()
    {
        titlePanel = GameObject.Find("titlePanel");
        //CanvasGroup cv = titlePanel.GetComponent<CanvasGroup>();
       // cv.alpha = 1;
        optionPanel = GameObject.Find("optionPanel");
        //CanvasGroup cv2 = optionPanel.GetComponent<CanvasGroup>();
       // cv2.alpha = 0;
    }
    

    public void ChangeToOption() 
    {
        CanvasGroup cv = titlePanel.GetComponent<CanvasGroup>();
        cv.alpha = 0;
        CanvasGroup cv2 = optionPanel.GetComponent<CanvasGroup>();
        cv2.alpha = 1;
    }

}
