using UnityEngine;
using System.Collections;

public class TextureScroll1 : MonoBehaviour {
    public float scrollSpeed;
    //private Vector2 myOffset = new Vector2(0, 1);
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        float y1 = Mathf.Repeat(Time.time * scrollSpeed, 1f);
        //float y2 = Mathf.Repeat((Time.time * scrollSpeed)+.9f, 1f);
        Vector2 offset1 = new Vector2(0, y1);
        //Vector2 offset2 = new Vector2(0, y2);
        gameObject.GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset1);      
        //gameObject.GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_DetailAlbedoMap", offset2);
    }
}
