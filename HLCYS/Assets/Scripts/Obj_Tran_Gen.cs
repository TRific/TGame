using UnityEngine;
using System.Collections;

public class Obj_Tran_Gen : MonoBehaviour {
    public GameObject myBld;
    public float speed = 100.0f;
    private Vector3 startGenerationPoint1 = new Vector3(-5.8f, 1.5f, -200.0f);
    private Vector3 startGenerationPoint2 = new Vector3(5.0f, 1.5f, -200.0f);
    private Vector3 startGenerationPoint3 = new Vector3(-0.4f, 1.5f, -200.0f);
    int n;

    // Use this for initialization
    void Start () {
        myBld = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0f, 0f, speed * Time.deltaTime);
        if (myBld.transform.position.z > 225.0f)
     
        {
            //Instantiate(theStreet, startGenerationPoint1, Quaternion.identity);
            n = Random.Range(0,3);
            if (n == 0)
            {
                var go = Instantiate(myBld, startGenerationPoint1, Quaternion.identity) as GameObject;
               // go.AddComponent<Obj_Tran_Gen>();
                Destroy(gameObject);
            }
            else if (n == 1)
            {
                var go = Instantiate(myBld, startGenerationPoint2, Quaternion.identity) as GameObject;
               // go.AddComponent<Obj_Tran_Gen>();
                Destroy(gameObject);
            }
            else
            {
                var go = Instantiate(myBld, startGenerationPoint3, Quaternion.identity) as GameObject;
              //  go.AddComponent<Obj_Tran_Gen>();
                Destroy(gameObject);
            }

        }
        

    }
}
