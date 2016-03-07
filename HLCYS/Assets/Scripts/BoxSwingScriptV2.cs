using UnityEngine;
using System.Collections;

public class BoxSwingScriptV2 : MonoBehaviour {
    private float fingerStartTime = 0.0f;
    private Vector2 fingerStartPos = Vector2.zero;
    public Animator anim;
    static public bool player_is_dead = false;
    public GameObject GAMEOVER_MENU;
    public GameObject pauseMenu;
    public GameObject nopauseMenu;
	public AudioSource bike;
	public AudioClip crash_sfx;

    private bool isSwipe = false;
    private float minSwipeDist = 50.0f;
    private float maxSwipeTime = 0.5f;

    //mine
    static Vector3 pos7 = new Vector3(-5.8f, 2.7f, 25f);
    static public Vector3 pos8 = new Vector3(-0.4f, 2.7f, 25f);
    static public Vector3 pos9 = new Vector3(5.0f, 2.7f, 25f);
    //position 4,5,6 (mid 3)
    static public Vector3 pos4 = new Vector3(-5.8f, 2.7f, 12f);
    static public Vector3 pos5 = new Vector3(-0.4f, 2.7f, 12f);
    static public Vector3 pos6 = new Vector3(5.0f, 2.7f, 12f);
    //position 1,2,3 (bot 3)
    static public Vector3 pos1 = new Vector3(-5.8f, 2.7f, -3.8f);
    static public Vector3 pos2 = new Vector3(-0.4f, 2.7f, -3.8f);
    static public Vector3 pos3 = new Vector3(5.0f, 2.7f, -3.8f);
    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        transform.position = pos5;
        //transform.position = new Vector3(0.0f, -1.4f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {

        if (player_is_dead)
        {
            GAMEOVER_MENU.SetActive(true);
            pauseMenu.SetActive(false);
            nopauseMenu.SetActive(false);

            Time.timeScale = 0;

        }

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
                                    //Debug.Log("KEY RIGHT PRESSED");
                                    if (myPosition.Equals(pos7)) 
                                    {
                                        anim.Play("bankright", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos8);
                                    }
                                    else if (myPosition.Equals(pos4))
                                    {
                                        anim.Play("bankright", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos5);

                                    }
                                    else if (myPosition.Equals(pos1))
                                    {
                                        anim.Play("bankright", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos2);

                                    }
                                    else if (myPosition.Equals(pos8))
                                    {
                                        anim.Play("bankright", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos9);
                                     
                                    }
                                    else if (myPosition.Equals(pos5))
                                    {
                                        anim.Play("bankright", -1, 0f);                                       
                                        StartCoroutine("MoveToTarget", pos6);
                                      
                                    }
                                    else if (myPosition.Equals(pos2))
                                    {
                                        anim.Play("bankright", -1, 0f);                                      
                                        StartCoroutine("MoveToTarget", pos3);
                                      
                                    }
                                    else
                                    {
                                        //Debug.Log("BITCH YA DON FCKED UP");
                                    }
                               
                                }
                                else {
                                    // MOVE LEFT
                                    //Debug.Log("KEY LEFT PRESSED");
                                    if (myPosition.Equals(pos8))
                                    {
                                        StartCoroutine("MoveToTarget", pos7);                                    
                                        anim.Play("bankleft", -1, 0f);
                                    }
                                    else if (myPosition.Equals(pos5))
                                    {
                                        anim.Play("bankleft", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos4);

                                    }
                                    else if (myPosition.Equals(pos2))
                                    {
                                        anim.Play("bankleft", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos1);

                                    }
                                    else if (myPosition.Equals(pos9))
                                    {
                                        anim.Play("bankleft", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos8);

                                    }
                                    else if (myPosition.Equals(pos6))
                                    {
                                        anim.Play("bankleft", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos5);

                                    }
                                    else if (myPosition.Equals(pos3))
                                    {
                                        anim.Play("bankleft", -1, 0f);
                                        StartCoroutine("MoveToTarget", pos2);

                                    }
                                    else
                                    {
                                        //Debug.Log("BITCH YA DON FCKED UP");
                                    }

                                }
                            }

                            if (swipeType.y != 0.0f)
                            {
                                if (swipeType.y > 0.0f)
                                {
                                    // MOVE UP
                                    //Debug.Log("KEY UP PRESSED");
                                    if (myPosition.Equals(pos1))
                                    {
                                        StartCoroutine("MoveToTarget", pos4);
                                    }
                                    else if (myPosition.Equals(pos2))
                                    {
                                        StartCoroutine("MoveToTarget", pos5);
                                    }
                                    else if (myPosition.Equals(pos3))
                                    {
                                        StartCoroutine("MoveToTarget", pos6);
                                    }
                                    else if (myPosition.Equals(pos4))
                                    {
                                        StartCoroutine("MoveToTarget", pos7);
                                    }
                                    else if (myPosition.Equals(pos5))
                                    {
                                        StartCoroutine("MoveToTarget", pos8);
                                    }
                                    else if (myPosition.Equals(pos6))
                                    {
                                        StartCoroutine("MoveToTarget", pos9);
                                    }
                                    else
                                    {
                                        //Debug.Log("BITCH YA DON FCKED UP");
                                    }

                                }
                                else {
                                    // MOVE DOWN
                                    //Debug.Log("KEY DOWN PRESSED");
                                    if (myPosition.Equals(pos7))
                                    {
                                        StartCoroutine("MoveToTarget", pos4);
                                    }
                                    else if (myPosition.Equals(pos8))
                                    {
                                        StartCoroutine("MoveToTarget", pos5);
                                    }
                                    else if (myPosition.Equals(pos9))
                                    {
                                        StartCoroutine("MoveToTarget", pos6);
                                    }
                                    else if (myPosition.Equals(pos4))
                                    {
                                        StartCoroutine("MoveToTarget", pos1);
                                    }
                                    else if (myPosition.Equals(pos5))
                                    {
                                        StartCoroutine("MoveToTarget", pos2);
                                    }
                                    else if (myPosition.Equals(pos6))
                                    {
                                        StartCoroutine("MoveToTarget", pos3);
                                    }
                                    else
                                    {
                                        //Debug.Log("BITCH YA DON FCKED UP");
                                    }


                                }
                            }

                        }

                        break;
                }
            }
        }


    }


    IEnumerator MoveToTarget(Vector3 dest)
    {
        Vector3 targetPosition = dest;
        float someSpeedFactor = 20f;
        //  Debug.Log("At least this was called..... DOOOD DO YOU SEE THIS??!?!?!");
        while ((transform.position - targetPosition).magnitude > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, someSpeedFactor * Time.deltaTime);
            yield return null;
        }
        transform.position = dest;       
    }


    void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.name == "Cube")
        //{
		bike.PlayOneShot(crash_sfx,0.2f);
        Destroy(col.gameObject);
        Debug.Log(col.gameObject.name);
        player_is_dead = true;
        //}a
    }

}
