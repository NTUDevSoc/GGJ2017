using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public string parent;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKey("up"))
        //{
        //    //    transform.position += transform.forward * 5;

        //    Vector3 dirX = transform.right *50;
        //    Vector3 dirY = transform.up * 50;

        //    rb2d.AddForce(new Vector2(dirX.x, dirY.y));
        //}

       // Vector3 nPos = this.transform.rotation.eulerAngles; //* a in this direction
       // Vector3 calcPos = Vector3.Scale(nPos, new Vector3(1.0f, 1.0f, 1.0f));
       //// Debug.Log("The resolved pos" + nPos);
       // //this.transform.position(this.transform/p)

       // transform.Translate(this.transform.position + calcPos);
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.CompareTag("Background"))
        {
            gameObject.SetActive(false);
        }
    }

}
