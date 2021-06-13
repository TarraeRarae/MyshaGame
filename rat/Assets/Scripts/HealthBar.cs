using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public RawImage bar;
    public float fill;
    private Vector3 startScale;
    private Vector3 newScale;
    public Player playerScript;

    void Start()
    {
        startScale = bar.transform.localScale;
        fill = startScale.x;
        newScale = startScale;
        playerScript = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {
        newScale.x = fill;
        bar.transform.localScale = newScale;
        fill = (float)playerScript.getSatiety()/100 * startScale.x;
    }
}
