using UnityEngine;
using System.Collections;

public class BoxScriptSwipe : MonoBehaviour {

    public float minSwipeDistY;

    public float minSwipeDistX;


    private Vector2 startPos;

    //mystuff
    public float speed = 1f;
    //public float delay = 0.5f;
    //position 7,8,9 (top 3)
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
    //end of mystuff

    void Update()
    {
        var myPosition = transform.position;
        //#if UNITY_ANDROID
        if (Input.touchCount > 0)

        {

            Touch touch = Input.touches[0];



            switch (touch.phase)

            {

                case TouchPhase.Began:

                    startPos = touch.position;

                    break;



                case TouchPhase.Ended:

                    float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;

                    if (swipeDistVertical > minSwipeDistY)

                    {

                        float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

                        if (swipeValue > 0)
                        {
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
                        }//up swipe

                        //Jump ();

                        else if (swipeValue < 0)
                        {
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
                        }//down swipe

                            //Shrink ();

                    }

                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;

                    if (swipeDistHorizontal > minSwipeDistX)

                    {

                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);

                        if (swipeValue > 0)
                        {
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
                        }//right swipe

                        //MoveRight ();

                        else if (swipeValue < 0)
                        {
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
                        }//left swipe

                            //MoveLeft ();

                    }
                    break;
            }
        }
    }

}
