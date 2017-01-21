using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionAI : MonoBehaviour {

    private Vector3 expand = new Vector3(0,0,1);

    float n = 0;

    // Use this for initialization
    void Start() {

        gameObject.transform.localScale=expand;
		
	}
	
	// Update is called once per frame
	void Update () {
        n = n + 0.00167F;
        expand = new Vector3(n, n, 1);
		if (n >= 1.05)
        {
            Destroy(gameObject);
        }
        gameObject.transform.localScale = expand;
	}
}
