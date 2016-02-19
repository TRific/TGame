using UnityEngine;
using System.Collections;

public class BoxScriptV2Test : MonoBehaviour {

    public Animator anim;
    public float speed = 9f;
    public bool player_is_dead = false;
    public GameObject GAMEOVER_MENU;
    public GameObject pauseMenu;
    public GameObject nopauseMenu;

    //private bool lerpOn = false;
    //public float delay = 0.5f;
    //position 7,8,9 (top 3)
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

    IEnumerator DelayTimer()
    {
        yield return new WaitForSeconds(0.5f);
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        //print("Start Object");
        transform.position = pos5;
        //transform.position = new Vector3(0.0f, -1.4f, -1.5f);
    }

    // Update is called once per frame
    void Update()
    {

        if (player_is_dead)
        {
            GAMEOVER_MENU.SetActive(true);
            pauseMenu.SetActive(false);
            nopauseMenu.SetActive(false);
            
            Time.timeScale = 0;

        }
        var myPosition = transform.position;
        //Debug.Log(myPosition);
        //Debug.Log("IN UPDATE");
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Debug.Log("KEY RIGHT PRESSED");
            if (myPosition.Equals(pos7)) //7 will go to pos8
            {
                anim.Play("bankright", -1, 0f);
               // lerpOn = true;
             //   Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos8);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos8;

            }
            else if (myPosition.Equals(pos4))
            {
                anim.Play("bankright", -1, 0f);
              //  lerpOn = true;
             //   Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos5);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos5;
            }
            else if (myPosition.Equals(pos1))
            {
                anim.Play("bankright", -1, 0f);
              //  lerpOn = true;
             //   Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos2);
             //   Debug.Log("I AM CALLED AFTER");
                //transform.position = pos2;
            }
            else if (myPosition.Equals(pos8))
            {
                anim.Play("bankright", -1, 0f);
               // lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos9);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos9;
            }
            else if (myPosition.Equals(pos5))
            {                              
                    anim.Play("bankright", -1, 0f);
                // gameObject.AddComponent<Lerping>();
                //lerpOn = true;
                //MoveObject(pos5, pos6, 0.5f);
                //    lerpOn = true;
               //     Debug.Log("I AM CALLED BEFORE");
                    StartCoroutine("MoveToTarget", pos6);
               //     Debug.Log("I AM CALLED AFTER");
                //transform.Translate(speed*Time.deltaTime,0f,0f);
                //transform.position = pos6;
            }
            else if (myPosition.Equals(pos2))
            {
                anim.Play("bankright", -1, 0f);
                //transform.position = pos3;
               // lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos3);
              //  Debug.Log("I AM CALLED AFTER");
            }
            else
            {
                //Debug.Log("BITCH YA DON FCKED UP");
            }
            //Debug.Log("Right Pressed");
            //transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Debug.Log("KEY LEFT PRESSED");
            if (myPosition.Equals(pos8))
            {
             //   lerpOn = true;
             //   Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos7);
              //  Debug.Log("I AM CALLED AFTER");
                anim.Play("bankleft", -1, 0f);
                //transform.position = pos7;
            }
            else if (myPosition.Equals(pos5))
            {
                anim.Play("bankleft", -1, 0f);
              //  lerpOn = true;
             //   Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos4);
             //   Debug.Log("I AM CALLED AFTER");
               // transform.position = pos4;
            }
            else if (myPosition.Equals(pos2))
            {
                anim.Play("bankleft", -1, 0f);
              //  lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos1);
               // Debug.Log("I AM CALLED AFTER");
               // transform.position = pos1;
            }
            else if (myPosition.Equals(pos9))
            {
                anim.Play("bankleft", -1, 0f);
                //transform.position = pos8;
              //  lerpOn = true;
               // Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos8);
               // Debug.Log("I AM CALLED AFTER");
            }
            else if (myPosition.Equals(pos6))
            {
             
                //    lerpOn = true;
                    anim.Play("bankleft", -1, 0f);
                 //   Debug.Log("I AM CALLED BEFORE");
                    StartCoroutine("MoveToTarget", pos5);
                //    Debug.Log("I AM CALLED AFTER");
                    
                
               
                //transform.position = pos5;
            }
            else if (myPosition.Equals(pos3))
            {
                anim.Play("bankleft", -1, 0f);
                //transform.position = pos2;
              //  lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos2);
              //  Debug.Log("I AM CALLED AFTER");
            }
            else
            {
                //Debug.Log("BITCH YA DON FCKED UP");
            }
            //Debug.Log("Left Pressed");
            //transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("KEY UP PRESSED");
            if (myPosition.Equals(pos1))
            {
              //  lerpOn = true;
               // Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos4);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos4;
            }
            else if (myPosition.Equals(pos2))
            {
               // lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos5);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos5;
            }
            else if (myPosition.Equals(pos3))
            {
               // lerpOn = true;
               // Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos6);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos6;
            }
            else if (myPosition.Equals(pos4))
            {
              //  lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos7);
             //   Debug.Log("I AM CALLED AFTER");
               // transform.position = pos7;
            }
            else if (myPosition.Equals(pos5))
            {
              //  lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos8);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos8;
            }
            else if (myPosition.Equals(pos6))
            {
             //   lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos9);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos9;
            }
            else
            {
                //Debug.Log("BITCH YA DON FCKED UP");
            }
            //Debug.Log("UP Pressed");
            //transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("KEY DOWN PRESSED");
            if (myPosition.Equals(pos7))
            {
              //  lerpOn = true;
               // Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos4);
             //   Debug.Log("I AM CALLED AFTER");
                //transform.position = pos4;
            }
            else if (myPosition.Equals(pos8))
            {
              //  lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos5);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos5;
            }
            else if (myPosition.Equals(pos9))
            {
               // lerpOn = true;
               // Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos6);
               // Debug.Log("I AM CALLED AFTER");
                //transform.position = pos6;
            }
            else if (myPosition.Equals(pos4))
            {
               // lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos1);
               // Debug.Log("I AM CALLED AFTER");
                //transform.position = pos1;
            }
            else if (myPosition.Equals(pos5))
            {
               // lerpOn = true;
               // Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos2);
               // Debug.Log("I AM CALLED AFTER");
                //transform.position = pos2;
            }
            else if (myPosition.Equals(pos6))
            {
               // lerpOn = true;
              //  Debug.Log("I AM CALLED BEFORE");
                StartCoroutine("MoveToTarget", pos3);
              //  Debug.Log("I AM CALLED AFTER");
                //transform.position = pos3;
            }
            else
            {
                //Debug.Log("BITCH YA DON FCKED UP");
            }
            //Debug.Log("DOWN Pressed");
            //transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        //Debug.Log(myPosition);

    }




    IEnumerator MoveObject(Vector3 source, Vector3 target, float overTime)
    {
        float startTime = Time.time;
        while (Time.time < startTime + overTime)
        {
            transform.position = Vector3.Lerp(source, target, (Time.time - startTime) / overTime);
            yield return null;
        }
        transform.position = target;
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
       // Debug.Log("OK WE ARE LEAVING!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");        
        //StopCoroutine("MoveToTarget");
       // Debug.Log("I AM STOPPED");
       // lerpOn = false;
    }

    void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.name == "Cube")
        //{
        Destroy(col.gameObject);
        Debug.Log(col.gameObject.name);
        player_is_dead = true;
        //}a
    }
}
