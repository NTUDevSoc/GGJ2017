using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        var myPrefab = Resources.Load("missile");
        Debug.Log(myPrefab);
        var instance = (GameObject)Instantiate(myPrefab);
        Debug.Log(instance);
        Vector2 rand = new Vector2(Random.Range(-200, 200)/100, Random.Range(-200, 200)/100);
        Instantiate(instance, rand, Quaternion.Euler(0, 0, Random.Range(0,360)));

    }
}
