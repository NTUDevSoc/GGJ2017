using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string player;
    public double velocityLimit = 2.5;
    public float speed = 5;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis($"Horizontal_{player}");
        float moveVertical = Input.GetAxis($"Vertical_{player}");
        
        if ((rb2d.velocity.x > velocityLimit && moveHorizontal > 0)
            || (rb2d.velocity.x < (0 - velocityLimit) && moveHorizontal < 0))
        {
            moveHorizontal = 0;
        }
        if ((rb2d.velocity.y > velocityLimit && moveVertical > 0)
            || (rb2d.velocity.y < (0 - velocityLimit) && moveVertical < 0))
        {
            moveVertical = 0;
        }

        rb2d.AddForce(new Vector2(moveHorizontal, moveVertical) * speed);
    }
}
