using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string player;
    public float speed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis($"Horizontal_{player}");
        float moveVertical = Input.GetAxis($"Vertical_{player}");
        rb2d.AddForce(new Vector2(moveHorizontal, moveVertical) * speed);
    }
}
