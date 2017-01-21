using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileAI : MonoBehaviour {
    public Rigidbody2D miss;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        var distance = Vector2.Distance(miss.transform.position, GameObject.Find("player_1").transform.position);

        var distance2 = Vector2.Distance(miss.transform.position, GameObject.Find("player_2").transform.position);

        Debug.Log(distance + distance2);
    }
}
