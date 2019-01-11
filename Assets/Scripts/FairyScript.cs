using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyScript : MonoBehaviour {


    public GameObject bullet;
    public int timer;
    






	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer++;

        if (timer == 20)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            timer -= 20;
        }

    }
}
