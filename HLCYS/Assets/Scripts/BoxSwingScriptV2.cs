using UnityEngine;
using System.Collections;

public class BoxSwingScriptV2 : MonoBehaviour {
    private float fingerStartTime = 0.0f;
    private Vector2 fingerStartPos = Vector2.zero;

    private bool isSwipe = false;
    private float minSwipeDist = 50.0f;
    private float maxSwipeTime = 0.5f;

    //mine
    static Vector3 pos7 = new Vector3(-2.42f, 0.0f, 0.0f);
    static public Vector3 pos8 = new Vector3(0.0f, 0.0f, 0.0f);
    static public Vector3 pos9 = new Vector3(2.42f, 0.0f, 0.0f);
    //position 4,5,6 (mid 3)
    static public Vector3 pos4 = new Vector3(-3.22f, -1.4f, 0.0f);
    static public Vector3 pos5 = new Vector3(0.0f, -1.4f, 0.0f);
    static public Vector3 pos6 = new Vector3(3.22f, -1.4f, 0.0f);
    //position 1,2,3 (bot 3)
    static public Vector3 pos1 = new Vector3(-3.8f, -3.22f, 0.0f);
    static public Vector3 pos2 = new Vector3(0.0f, -3.22f, 0.0f);
    static public Vector3 pos3 = new Vector3(3.8f, -3.22f, 0.0f);
    // Use this for initialization
    void Start () {
        transform.position = new Vector3(0.0f, -1.4f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
        var myPosition = transform.position;
        if (Input.touchCount > 0){

            foreach (Touch touch in Input.touches)
            {
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        /* this is a new touch */
                        isSwipe = true;
                        fingerStartTime = Time.time;
                        fingerStartPos = touch.position;
                        break;

                    case TouchPhase.Canceled:
                        /* The touch is being canceled */
                        isSwipe = false;
                        break;

                    case TouchPhase.Ended:

                        float gestureTime = Time.time - fingerStartTime;
                        float gestureDist = (touch.position - fingerStartPos).magnitude;

                        if (isSwipe && gestureTime < maxSwipeTime && gestureDist > minSwipeDist)
                        {
                            Vector2 direction = touch.position - fingerStartPos;
                            Vector2 swipeType = Vector2.zero;

                            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                            {
                                // the swipe is horizontal:
                                swipeType = Vector2.right * Mathf.Sign(direction.x);
                            }
                            else {
                                // the swipe is vertical:
                                swipeType = Vector2.up * Mathf.Sign(direction.y);
                            }

                            if (swipeType.x != 0.0f)
                            {
                                if (swipeType.x > 0.0f)
                                {
                                    // MOVE RIGHT
                                    if (myPosition.Equals(pos7)) //7 will go to pos8
                                    {
                                        transform.position = pos8;
                                    }
                                    else if (myPosition.Equals(pos4))
                                    {
                                        transform.position = pos5;
                                    }
                                    else if (myPosition.Equals(pos1))
                                    {
                                        transform.position = pos2;
                                    }
                                    else if (myPosition.Equals(pos8))
                                    {
                                        transform.position = pos9;
                                    }
                                    else if (myPosition.Equals(pos5))
                                    {
                                        transform.position = pos6;
                                    }
                                    else if (myPosition.Equals(pos2))
                                    {
                                        transform.position = pos3;
                                    }
                                    else
                                    {
                                        Debug.Log("BITCH YA DON FCKED UP");
                                    }
                                }
                                else {
                                    // MOVE LEFT
                                    if (myPosition.Equals(pos8))
                                    {
                                        transform.position = pos7;
                                    }
                                    else if (myPosition.Equals(pos5))
                                    {
                                        transform.position = pos4;
                                    }
                                    else if (myPosition.Equals(pos2))
                                    {
                                        transform.position = pos1;
                                    }
                                    else if (myPosition.Equals(pos9))
                                    {
                                        transform.position = pos8;
                                    }
                                    else if (myPosition.Equals(pos6))
                                    {
                                        transform.position = pos5;
                                    }
                                    else if (myPosition.Equals(pos3))
                                    {
                                        transform.position = pos2;
                                    }
                                    else
                                    {
                                        Debug.Log("BITCH YA DON FCKED UP");
                                    }
                                }
                            }

                            if (swipeType.y != 0.0f)
                            {
                                if (swipeType.y > 0.0f)
                                {
                                    // MOVE UP
                                    if (myPosition.Equals(pos1))
                                    {
                                        transform.position = pos4;
                                    }
                                    else if (myPosition.Equals(pos2))
                                    {
                                        transform.position = pos5;
                                    }
                                    else if (myPosition.Equals(pos3))
                                    {
                                        transform.position = pos6;
                                    }
                                    else if (myPosition.Equals(pos4))
                                    {
                                        transform.position = pos7;
                                    }
                                    else if (myPosition.Equals(pos5))
                                    {
                                        transform.position = pos8;
                                    }
                                    else if (myPosition.Equals(pos6))
                                    {
                                        transform.position = pos9;
                                    }
                                    else
                                    {
                                        Debug.Log("BITCH YA DON FCKED UP");
                                    }
                                }
                                else {
                                    // MOVE DOWN
                                    if (myPosition.Equals(pos7))
                                    {
                                        transform.position = pos4;
                                    }
                                    else if (myPosition.Equals(pos8))
                                    {
                                        transform.position = pos5;
                                    }
                                    else if (myPosition.Equals(pos9))
                                    {
                                        transform.position = pos6;
                                    }
                                    else if (myPosition.Equals(pos4))
                                    {
                                        transform.position = pos1;
                                    }
                                    else if (myPosition.Equals(pos5))
                                    {
                                        transform.position = pos2;
                                    }
                                    else if (myPosition.Equals(pos6))
                                    {
                                        transform.position = pos3;
                                    }
                                    else
                                    {
                                        Debug.Log("BITCH YA DON FCKED UP");
                                    }
                                }
                            }

                        }

                        break;
                }
            }
        }


    }
}
