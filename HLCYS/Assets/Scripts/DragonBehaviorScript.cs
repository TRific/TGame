using UnityEngine;
using System.Collections;

public class DragonBehaviorScript : MonoBehaviour {
    public Animator anima;
    public GameObject player;
	public AudioSource dragon;
	public AudioClip cannon_sfx;
	public AudioClip roar_sfx;
	public AudioClip coil_sfx;
	public AudioClip tailslam_sfx;

	bool looper = true;
    int n;
    //fireball pos
    static public Vector3 fpos7 = new Vector3(-5.8f, 39.5f, 25f);
    static public Vector3 fpos8 = new Vector3(-0.4f, 39.5f, 25f);
    static public Vector3 fpos9 = new Vector3(5.0f, 39.5f, 25f);
    //position 4,5,6 (mid 3)
    static public Vector3 fpos4 = new Vector3(-5.8f, 39.5f, 12f);
    static public Vector3 fpos5 = new Vector3(-0.4f, 39.5f, 12f);
    static public Vector3 fpos6 = new Vector3(5.0f, 39.5f, 12f);
    //position 1,2,3 (bot 3)
    static public Vector3 fpos1 = new Vector3(-5.8f, 39.5f, -3.8f);
    static public Vector3 fpos2 = new Vector3(-0.4f, 39.5f, -3.8f);
    static public Vector3 fpos3 = new Vector3(5.0f, 39.5f, -3.8f);


    //indicator pos
    static public Vector3 ipos7 = new Vector3(-5.8f, 0.1f, 25f);
    static public Vector3 ipos8 = new Vector3(-0.4f, 0.1f, 25f);
    static public Vector3 ipos9 = new Vector3(5.0f, 0.1f, 25f);
    //position 4,5,6 (mid 3)
    static public Vector3 ipos4 = new Vector3(-5.8f, 0.1f, 12f);
    static public Vector3 ipos5 = new Vector3(-0.4f, 0.1f, 12f);
    static public Vector3 ipos6 = new Vector3(5.0f, 0.1f, 12f);
    //position 1,2,3 (bot 3)
    static public Vector3 ipos1 = new Vector3(-5.8f, 0.1f, -3.8f);
    static public Vector3 ipos2 = new Vector3(-0.4f, 0.1f, -3.8f);
    static public Vector3 ipos3 = new Vector3(5.0f, 0.1f, -3.8f);

    static public Vector3 bpos3 = new Vector3(5.0f, 2.7f, -3.8f);
    static public Vector3 bpos6 = new Vector3(5.0f, 2.7f, 12f);
    static public Vector3 bpos9 = new Vector3(5.0f, 2.7f, 25f);

    // Use this for initialization
    void Start () {
        anima = GetComponent<Animator>();

		StartCoroutine(chooseAttacks());

       
        //chooseAttacks();   
    }

    void Update()
    {
    
    }

   IEnumerator chooseAttacks()
    {
		while (looper) {

			n = Random.Range(1, 5); //1 to 100
			Debug.Log(n);
			if (n == 1)
			{
				tailSlap();
				dragon.PlayOneShot (tailslam_sfx, 0.5f);
				yield return new WaitForSeconds(2.0f);

				var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos3, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
				var go2 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos6, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
				var go3 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos9, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
				yield return new WaitForSeconds(0.8f);
				Debug.Log(player.transform.position);
				if (player.transform.position == bpos3 || player.transform.position == bpos6 || player.transform.position == bpos9)
				{
					BoxSwingScriptV2.player_is_dead = true;//for andriod swipe
					//BoxScriptV2Test.player_is_dead = true;
					Debug.Log("YEA");
				}
				yield return new WaitForSeconds(0.1f);
				Debug.Log(player.transform.position);
				if (player.transform.position == bpos3 || player.transform.position == bpos6 || player.transform.position == bpos9)
				{
					BoxSwingScriptV2.player_is_dead = true;//for andriod swipe
					//BoxScriptV2Test.player_is_dead = true;
					Debug.Log("YEA");
				}
				yield return new WaitForSeconds(0.1f);
				Debug.Log(player.transform.position);
				if (player.transform.position == bpos3 || player.transform.position == bpos6 || player.transform.position == bpos9)
				{
					BoxSwingScriptV2.player_is_dead = true;//for andriod swipe
					//BoxScriptV2Test.player_is_dead = true;
					Debug.Log("YEA");
				}
				yield return new WaitForSeconds(2.0f);
				Debug.Log("tail");
			}

			else if (n == 4)
			{

				anima.Play("fire");
				Debug.Log("fire");

				yield return new WaitForSeconds(1.0f);
				dragon.PlayOneShot (coil_sfx, 0.5f);
				yield return new WaitForSeconds(3.0f);
				dragon.PlayOneShot (roar_sfx, 0.4f);
				yield return new WaitForSeconds(1.0f);
				for(int i = 0; i < 6; i++)
				{
					fireShot();
					dragon.PlayOneShot(cannon_sfx,0.3f);
					yield return new WaitForSeconds(0.5f);
				}
			}
			else
			{
				Debug.Log("loop");
				chooseAttacks();

			}


		}// end of while true


       
    }
	
    void tailSlap()
    {
        anima.Play("tailslap");
        //StartCoroutine(animationWaitTimer1(anima));
    }

    void fireShot()
    {
        //anima.Play("fire");   
        n = Random.Range(1, 10);

            if(n == 1)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos1, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos1, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
            else if (n == 2)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos2, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos2, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
            else if (n == 3)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos3, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos3, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
            else if (n == 4)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos4, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos4, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
            else if (n == 5)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos5, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos5, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
            else if (n == 6)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos6, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos6, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
            else if (n == 7)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos7, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos7, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
            else if (n == 8)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos8, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos8, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
            else if (n == 9)
            {
                var go = Instantiate(Resources.Load("Fireball", typeof(GameObject)), fpos9, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
                var go1 = Instantiate(Resources.Load("redplane", typeof(GameObject)), ipos9, Quaternion.Euler(0.0f, 180.0f, 0.0f)) as GameObject;
            }
        }
        

        //StartCoroutine(animationWaitTimer2(anima));

    

    IEnumerator animationWaitTimer1(Animator a)
    {
        //Animation t = a.GetComponent<Animation>();
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t1");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t2");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t3");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t4");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t5");
    }

    IEnumerator animationWaitTimer2(Animator a)
    {
        //Animation t = a.GetComponent<Animation>();
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t1");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t2");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t3");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t4");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t5");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t6");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t7");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("t8");
    }

    IEnumerator stallingTime()
    {
        yield return new WaitForSeconds(4.0f);
        Debug.Log("1");
        yield return new WaitForSeconds(4.0f);
        Debug.Log("2");
    }
}
