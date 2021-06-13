using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poision2 : Bonuses
{
    private Player playerScript;

    private void Awake()
    {
        playerScript = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    protected override void changeAtributes()
    {
        playerScript.setSatiety(playerScript.getSatiety() - change);
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
