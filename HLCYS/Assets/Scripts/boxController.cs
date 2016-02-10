using UnityEngine;
using System.Collections;

public class boxController : MonoBehaviour {

    //public enum boxStates { box };
    //public boxStates currentstate;

    //Menu Panel Objects
    public GameObject theBox;

    //for locating position of box
    //Vector2 myPosition;

    //position 7,8,9 (top 3)
    public Vector2 pos7 = new Vector2(-2.42f, 0.0f);
    public Vector2 pos8 = new Vector2(0.0f, 0.0f);
    public Vector2 pos9 = new Vector2(2.42f, 0.0f);
    //position 4,5,6 (mid 3)
    public Vector2 pos4 = new Vector2(-3.22f, -1.4f);
    public Vector2 pos5 = new Vector2(0.0f, -1.4f);
    public Vector2 pos6 = new Vector2(3.22f, -1.4f);
    //position 1,2,3 (bot 3)
    public Vector2 pos1 = new Vector2(-3.8f, -3.22f);
    public Vector2 pos2 = new Vector2(0.0f, -3.22f);
    public Vector2 pos3 = new Vector2(3.8f, -3.22f);
    

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
       



        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (myPosition.Equals(pos7)|| myPosition.Equals(pos8) || myPosition.Equals(pos9))
            {

            }
            //move up
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            //move down
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //move right
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //move left
        }
        */
        
    }

}
