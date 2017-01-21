using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_1_movement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal_1");
        float moveVertical = Input.GetAxis("Vertical_1");
        rb2d.AddForce(new Vector2(moveHorizontal, moveVertical) * speed);
    }
}
