using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate( 0f, 0f, speed * Time.deltaTime);
	}
}
