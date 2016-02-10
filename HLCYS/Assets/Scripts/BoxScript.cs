using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {
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
    // Use this for initialization  

    IEnumerator DelayTimer()
    {
        yield return new WaitForSeconds(0.5f);
    }

    void Start() {
        
        print("Start Object");
        transform.position = new Vector3(0.0f, -1.4f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {        
        var myPosition = transform.position;
        Debug.Log(myPosition);
        if (Input.GetKeyDown(KeyCode.RightArrow))
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
            Debug.Log("Right Pressed");          
            //transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
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
            Debug.Log("Left Pressed");
            //transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
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
            Debug.Log("UP Pressed");
            //transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
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
            Debug.Log("DOWN Pressed");
            //transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        //Debug.Log(myPosition);
    
       }

    
        




}
