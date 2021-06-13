using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Bonuses: MonoBehaviour
{
    protected float change = 40;
    abstract protected void changeAtributes();
    abstract protected void OnTriggerEnter(Collider col);
}
