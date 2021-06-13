using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoes : MonoBehaviour
{
    private Player playerScript;

    public void Awake()
    {
        playerScript = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            playerScript.setSatiety(0);
            
        }
    }
}
