using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : Bonuses
{
    private Player playerScript;

    private void Awake()
    {
        playerScript = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    void FixedUpdate()
    {
        Quaternion rotationY = Quaternion.AngleAxis(5, Vector3.up);
        transform.rotation *= rotationY;
    }

    protected override void changeAtributes()
    {
        playerScript.setSatiety(playerScript.getSatiety() + change);
        gameObject.SetActive(false);
    }

    protected override void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            changeAtributes();
        }
    }
}
