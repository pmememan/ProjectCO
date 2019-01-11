using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript2 : MonoBehaviour {


    public Transform player;
    public int speed;

    void Start()
    {
        // Add + 1 to player's last known position so bullet appears to float above ground.
        Vector3 playerPos = new Vector3(player.position.x, player.position.y + 1, player.position.z);

        // Aim bullet in player's direction.
        transform.rotation = Quaternion.LookRotation(playerPos);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the projectile forward towards the player's last known direction;
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
