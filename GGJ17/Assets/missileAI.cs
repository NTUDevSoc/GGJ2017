using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileAI : MonoBehaviour {

    private Rigidbody2D miss;
    public float colliderRange;

    void exploder ()
    {
        GameObject expGameObj = (GameObject)Resources.Load("explosion");
        Instantiate(expGameObj, gameObject.transform.position, gameObject.transform.rotation);
    }
    // Use this for initialization
    void Start ()
    {
        miss = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        var distToPlayer1 = Vector2.Distance(miss.transform.position, GameObject.Find("player_1").transform.position);

        var distToPlayer2 = Vector2.Distance(miss.transform.position, GameObject.Find("player_2").transform.position);

        if ( (distToPlayer1 <= colliderRange) || (distToPlayer2 <= colliderRange) )
        {
            exploder();
            Destroy(gameObject);
        }
        
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
