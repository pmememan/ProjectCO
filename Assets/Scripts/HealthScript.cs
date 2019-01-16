using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {



    public int health;
    public GameObject shot;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (health == 0)
        {
            Destroy(gameObject);
        }


	}


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "shot")
        {

            health--;

        }
        

   
    }
}
