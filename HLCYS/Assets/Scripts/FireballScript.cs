using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {

    public GameObject theFireBall;
	// Update is called once per frame
    void Start()
    {
        theFireBall = this.gameObject;
    }
	void Update () {
        if (theFireBall.transform.position.y < 0)
        {
            Destroy(gameObject);
        }

    }
}
