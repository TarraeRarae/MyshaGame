using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour {
    public Animator animator;
    public GameObject player;
    private float satiety = 100f;
    public Rigidbody rb;
    public float sideForce;
    public float upForce;
    private float codeTimer = 0.5f;
    private int anim = 1;

    public float getSatiety()
    {
        return satiety;
    }

    public void setSatiety(float newSatiety)
    {
        if (newSatiety > 100f)
            newSatiety = 100f;
        this.satiety = newSatiety;
        
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update() {

        satiety -= 0.1f;

        if (satiety <= 0)
        {
            animator.SetInteger("par", anim);
            FindObjectOfType<GameManager>().Death();

        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if ((Input.GetKey(KeyCode.Space)) && (player.transform.position.y < 1))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        codeTimer -= Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (codeTimer < 0) 
            {
                codeTimer = 0.5f;
                Debug.Log("Pause");
                FindObjectOfType<GameManager>().Pause();
            }
        }
    }
}
