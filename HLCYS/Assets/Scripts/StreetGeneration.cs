using UnityEngine;
using System.Collections;

public class StreetGeneration : MonoBehaviour {
    public GameObject theStreet;
    //public GameObject theStreet2;
    //public Transform generationPoint;
    //public float distanceBetween; //should be 0 i think for our case
    //yay
    //private float platformWidth;
    //private float distanceBetweenMin;
    //private float distanceBetweenMax;
    private Vector3 startGenerationPoint1 = new Vector3(-1.6f, 1.8f, -50.0f);
    //public Vector3 startGenerationPoint2 = new Vector3(0.0f, 0.0f, -40.0f);
    public float speed = -90.0f;
   
    // Use this for initialization
    void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, 0f, speed * Time.deltaTime);
   
       
        if(theStreet.transform.position.z > 265.0f && theStreet.transform.position.z < 267.0f)
        {
            //Instantiate(theStreet, startGenerationPoint1, Quaternion.identity);
            Instantiate(theStreet, startGenerationPoint1, Quaternion.Euler(0.0f,180.0f,0.0f));
            Destroy(gameObject);
        }
       
     
    }
}
