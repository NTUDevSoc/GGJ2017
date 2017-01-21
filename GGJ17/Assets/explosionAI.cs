using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionAI : MonoBehaviour {

    private Vector3 rescaleVector;
    private float timeElapsed;
    private float expansion;

    public float expansionRate;
    public float timeToDelete;

    // Use this for initialization
    void Start() {
        gameObject.transform.localScale = rescaleVector;
        timeElapsed = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;

        expansion += expansionRate;
        rescaleVector = new Vector3(expansion, expansion, 1);

        gameObject.transform.localScale = rescaleVector;

        if (timeElapsed > timeToDelete)
        {
            Destroy(gameObject);
        }
	}
}
