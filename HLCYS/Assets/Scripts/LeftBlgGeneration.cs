using UnityEngine;
using System.Collections;

public class LeftBlgGeneration : MonoBehaviour {
    public GameObject myBld;
    //public GameObject theBlg1;
    //public GameObject theBlg2;
    //public GameObject theBlg3;
    //public GameObject theBlg4;

    int n;
    //public GameObject theStreet2;
    //public Transform generationPoint;
    //public float distanceBetween; //should be 0 i think for our case

    //private float platformWidth;
    //private float distanceBetweenMin;
    //private float distanceBetweenMax;
    private Vector3 startGenerationPoint1 = new Vector3(27f, 0.0f, -55.0f);
    //public Vector3 startGenerationPoint2 = new Vector3(0.0f, 0.0f, -40.0f);
    public float speed = -100.0f;

    // Use this for initialization
    void Start()
    {
        myBld = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, speed * Time.deltaTime);

        if (myBld.transform.position.z > 225.0f)
        //if (myBld.transform.position.z > 260.0f && myBld.transform.position.z < 262.0f)
        {
            //Instantiate(theStreet, startGenerationPoint1, Quaternion.identity);
            n = Random.Range(0, 4);
            if (n == 0)
            {
                var go = Instantiate(Resources.Load("FullBuilding_1", typeof(GameObject)), startGenerationPoint1, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                go.AddComponent<LeftBlgGeneration>();
                Destroy(gameObject);
            }
            else if (n == 1)
            {
                var go = Instantiate(Resources.Load("FullBuilding_2", typeof(GameObject)), startGenerationPoint1, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                go.AddComponent<LeftBlgGeneration>();
                Destroy(gameObject);
            }
            else if (n == 2)
            {
                var go = Instantiate(Resources.Load("HalfBuildings_1", typeof(GameObject)), startGenerationPoint1, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                go.AddComponent<LeftBlgGeneration>();
                Destroy(gameObject);
            }
            else
            {
                var go = Instantiate(Resources.Load("TripleBuildings_1", typeof(GameObject)), startGenerationPoint1, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                go.AddComponent<LeftBlgGeneration>();
                Destroy(gameObject);
            }

        }


    }
}
