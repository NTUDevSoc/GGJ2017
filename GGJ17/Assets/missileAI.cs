using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileAI : MonoBehaviour {
    //public Rigidbody2D miss;
    private Rigidbody2D miss;
    void exploder (Vector3 orient)
    {
        GameObject instance = (GameObject)Resources.Load("explosion");
        Instantiate(instance, gameObject.transform.position, gameObject.transform.rotation);
    }
    // Use this for initialization
    void Start ()
    {
        miss = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        var distance = Vector2.Distance(miss.transform.position, GameObject.Find("player_1").transform.position);

        var distance2 = Vector2.Distance(miss.transform.position, GameObject.Find("player_2").transform.position);

        if (distance <= 0.8)
        {
            exploder(miss.transform.position);
            Destroy(gameObject);
        }
        else if (distance2 <= 0.8)
        {
            exploder(miss.transform.position);
            Destroy(gameObject);
        }
        
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
