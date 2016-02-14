using UnityEngine;
using System.Collections;

public class Lerping2 : MonoBehaviour {


    public Vector3 destination;
    public float speed = 9f;
    static public Vector3 pos5 = new Vector3(-0.4f, 2.1f, 12f);

    void Start()
    {
        destination = pos5;
        //destination = transform.position;
    }

    void Update()
    {
        //-1 is the layer and 0f is the time it starts
        transform.position = Vector3.Lerp(transform.position, destination, speed * Time.deltaTime);


    }
}
