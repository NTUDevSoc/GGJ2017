using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionAI : MonoBehaviour {

    private Vector3 expand = new Vector3(0,0,1);
    private float timeElapsed;
    private Camera viewport;

    public float rateOfExpansion;
    public float timeToDelete;

    // Use this for initialization
    void Start() {
        Debug.Log("Executing explosion.");
        viewport = Camera.main;
        timeElapsed = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        // Counting time since the start of the explosion - used for detecting when to destroy obj.
        timeElapsed += Time.deltaTime;

        // using Time.deltaTime (change in time per frame) to make expansion relative to fps
        expand = new Vector3(rateOfExpansion, rateOfExpansion, 1.0f) * Time.deltaTime;

        if (timeElapsed > timeToDelete)
        {
            Destroy(gameObject);
        }
	}
}
