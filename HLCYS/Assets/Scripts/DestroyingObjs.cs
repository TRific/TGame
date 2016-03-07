using UnityEngine;
using System.Collections;

public class DestroyingObjs : MonoBehaviour {
    public float secTime = 2.0f;
	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(secTime);
        Destroy(gameObject);
    }
	

}
