using UnityEngine;
using System.Collections;

public class SmoothT : MonoBehaviour {

    public Animator anim;
    public Vector3 destination;
    public float speed = 0.1f;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("bankright", -1, 0f);
        //destination = transform.position;
    }

    void Update()
    {
         //-1 is the layer and 0f is the time it starts
        transform.position = Vector3.Lerp(transform.position, destination, speed * Time.deltaTime);
        
    }

}
