using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtReal : MonoBehaviour {

    public Rigidbody2D rb;

    public int speed;

    PlayerMovement target;

    Vector2 moveDirection;

	// Use this for initialization
	void Start () {

        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);


		
	}
	
	// Update is called once per frame
	void Update () {
       
    }
}
