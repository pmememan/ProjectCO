using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {


    public float scrollspeed;

    Vector2 startpos;

	// Use this for initialization
	void Start () {
        startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {


        float newpos = Mathf.Repeat(Time.time * scrollspeed, 25);
        transform.position = startpos + Vector2.left * newpos;

	}
}
