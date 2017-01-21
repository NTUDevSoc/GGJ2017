using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionAI : MonoBehaviour {

    private Vector3 expand = new Vector3(0,0,1);

    float n = 0;

    // Use this for initialization
    void Start() {
        Debug.Log("blelele");

        gameObject.transform.localScale+=expand;
		
	}
	
	// Update is called once per frame
	void Update () {
        n = n + 177;
        expand = new Vector3(n/1000, n/1000, 1);
		if (n == 1050)
        {
            Destroy(gameObject);
        }
	}
}
