using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public GameObject bullet;
    public Rigidbody2D rb;
    public float speed;
    public int difficulty;
    public int danmaku;
    public int rotatedirection;
    public int isit;
    public int isdan;
    private float min;
    private float max;
    private float speeds;
    private float heights;
    public int spin;
    public GameObject player;

    
    

    Vector3 pointA = new Vector3(0, 0, 0);
    Vector3 pointB = new Vector3(1, 1, 1);

    // Use this for initialization
    void Start () {
        if (danmaku == 3)
        {
            min = transform.position.x;
            max = transform.position.x + 3;
        }
        if (danmaku == 4)
        {
            speeds = 5f;
            //adjust this to change how high it goes
            heights = 1f;
        }

        difficulty = GameObject.Find("Player").GetComponent<PlayerMovement>().difficulty;
        player = GameObject.Find("Player");

        if (rotatedirection > 0)
        {
            //isit = GameObject.Find("Boss1").GetComponent<Boss1Fight>().d;

            //isdan = GameObject.Find("Boss1").GetComponent<Boss1Fight>().dan;
        }
        if (isit == 1)
        {
            difficulty = 1;
        }

        if (isdan == 1)
        {
            danmaku = 1;
        }
        else if (isdan == 2)
        {
            danmaku = 2;
        }


        //Script for trash danmaku
        //1 = easy. 2 = normal. 3 = hard, 4 = lunatic
        if (danmaku == 1 || danmaku == 2 || danmaku == 3 || danmaku == 4)//Spiral Danmaku
        {
            if (difficulty == 1)
            {
                InvokeRepeating("Fire", 1f, 0.5f);
            }
            else if (difficulty == 2)
            {
                InvokeRepeating("Fire", 1f, 0.12f);
            }
            else if (difficulty == 3)
            {
                InvokeRepeating("Fire", 1f, 0.08f);
            }
            else if (difficulty == 4)
            {
                InvokeRepeating("Fire", 1f, 0.04f);
            }
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        if (rotatedirection == 1)
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (rotatedirection == 2)
        {
            transform.Rotate(Vector3.forward * -speed * Time.deltaTime);
        }

        if (spin == 1)
        {
            transform.RotateAround(player.transform.position, player.transform.forward, 100 * Time.deltaTime);
        }
        if (spin == 2)
        {
            transform.RotateAround(player.transform.position, player.transform.forward, 100 * Time.deltaTime);
        }


        if (danmaku == 2){

            speed++;

            if (difficulty == 4 && speed == 500)
            {
                speed -= 500;
            }
            else if (difficulty == 3 && speed == 230)
            {

                speed -= 1000;

            }
            else if (difficulty == 2 && speed >= 690)
            {

                speed -= 1200;

            }


        }

        if (danmaku == 3)
        {

            transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);
            
        }
        if (danmaku == 4)
        {
            Vector3 pos = transform.position;
            //calculate what the new Y position will be
            float newY = Mathf.Sin(Time.time * speeds);
            //set the object's Y to the new calculated Y
            transform.position = new Vector3(pos.x, newY+1, pos.z) * heights;
        }
    }

    void Fire()
    {
        if (danmaku == 1 || danmaku == 2 || danmaku==3 || danmaku==4) 
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
