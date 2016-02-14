using UnityEngine;
using System.Collections;

public class movingstreets : MonoBehaviour {
    public GameObject theStreet;
    private Vector3 startGenerationPoint1 = new Vector3(0.0f, 0.0f, -599.0f);
    //public Vector3 startGenerationPoint2 = new Vector3(0.0f, 0.0f, -40.0f);
    public float speed = 120.0f;
    // Use this for initialization
    void Start () {
        theStreet = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, 0f, speed * Time.deltaTime);


        if (theStreet.transform.position.z > 599.0f)
        {
            Instantiate(theStreet, startGenerationPoint1, Quaternion.identity);
           // Instantiate(theStreet, startGenerationPoint1, Quaternion.Euler(0.0f, 180.0f, 0.0f));
            Destroy(gameObject);
        }
    }
}
