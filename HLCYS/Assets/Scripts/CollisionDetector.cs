using UnityEngine;
using System.Collections;

public class CollisionDetector : MonoBehaviour {
    /*
    void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.name == "Cube")
        //{
            Destroy(col.gameObject);
      
        //}a
    }
    */
    void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.name == "Cube")
        //{
        Destroy(col.gameObject);
        Debug.Log(col.gameObject.name);
        //}a
    }

}
