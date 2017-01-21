using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missSpawn : MonoBehaviour {
    int n = 0;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        n = n + 1;
        if ((n % 21) == 0)
        {
            var instance = Resources.Load("missile");
            Vector2 rand = new Vector2(Random.Range(-400, 400) / 100, Random.Range(-400, 400) / 100);
            Instantiate(instance, rand, Quaternion.Euler(0, 0, Random.Range(0, 360)));
        }
        

    }
}
