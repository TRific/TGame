using UnityEngine;
using System.Collections;

public class CollisionObjDestroyer : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.name == "Cube")
        //{
        Destroy(this.gameObject);
        //Debug.Log(col.gameObject.name);
        //}a
    }
}
