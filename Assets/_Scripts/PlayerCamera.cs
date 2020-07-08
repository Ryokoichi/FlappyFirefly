using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public Transform playerTransform;
    float offsetx;
    
    
    void Start()
    {
        offsetx = transform.position.x - playerTransform.position.x;
    }

    void Update()
    {
        Vector3 position = transform.position;
        position.x = playerTransform.position.x + offsetx;

        transform.position = position;
    }
}
