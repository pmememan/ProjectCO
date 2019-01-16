using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript1 : MonoBehaviour {


    public int speed;
    public Rigidbody2D rb;
    public Collider2D collider;
    public int danmaku;

    // Use this for initialization
    void Start()
    {
        if (danmaku <= 0)
        {
            rb.AddForce(transform.up * speed);
            
        }
        if (danmaku == 1)
        {
            Invoke("shoot", 10f);
        }
        if (danmaku == 2)
        {
            Invoke("shoot", 5f);
        }

    }

    // Update is called once per frame
    void Update()
    {

        
    }


    void Destroyit()
    {
        
    }

    void shoot()
    {
        rb.AddForce(transform.up * speed);
       ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {

            Destroy(gameObject);

        }
    }
}
