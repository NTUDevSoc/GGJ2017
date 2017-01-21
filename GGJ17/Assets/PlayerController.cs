using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string player;
    public double velocityLimit = 2.5;
    public float speed = 5;
    private Rigidbody2D rb2d;
    private BoxCollider2D[] bc2ds;
    private CircleCollider2D[] cc2ds;
    public bool isAlive;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2ds = GetComponents<BoxCollider2D>();
        cc2ds = GetComponents<CircleCollider2D>();
        isAlive = true;
    }

    void FixedUpdate()
    {
        if (isAlive)
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
        else
        {
            for(int i = 0; i < cc2ds.Length; i++)
            {
                cc2ds[i].enabled = false;
            }
            for (int i = 0; i < bc2ds.Length; i++)
            {
                bc2ds[i].enabled = false;
            }
            rb2d.gravityScale = 1;
        }
    }
}
