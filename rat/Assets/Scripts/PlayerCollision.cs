using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision someCollision)
    {
        if (someCollision.collider.CompareTag("Obstacle"))
        {
            FindObjectOfType<Player>().setSatiety(0);
        }
     }

}
    
