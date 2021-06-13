using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;

    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
