using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileAI : MonoBehaviour {
    public Rigidbody2D p1;
    public Rigidbody2D p2;
    public GameObject miss;

    // Use this for initialization
    void Start () {
        miss = (GameObject)Instantiate(Resources.Load("missile"));
    }
	
	// Update is called once per frame
	void Update () {
        var distance = Vector2.Distance(miss.transform.position, GameObject.Find("player_1").transform.position);

        var distance2 = Vector2.Distance(miss.transform.position, GameObject.Find("player_2").transform.position);

        if (distance <= 50)
        {
            Destroy((GameObject)miss);
        }
        else if (distance2 <= 50)
        {
            Destroy((GameObject)miss);
        }


    }
}
