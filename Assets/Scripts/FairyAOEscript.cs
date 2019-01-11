using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyAOEscript : MonoBehaviour {

    public GameObject bullet;
    public int firespeed;
    public Rigidbody2D rb;



    [SerializeField]
    int speed;

    private int timer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        move();




        //timer++;

        //if (timer == firespeed)
        //{
        //    Instantiate(bullet, transform.position, transform.rotation);
        //    timer -= firespeed;
        //}

    }


    void move()
    {



        rb.transform.position += Vector3.right * speed * Time.deltaTime;



    }
}
