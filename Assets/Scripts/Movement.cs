using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 */
public class Movement : MonoBehaviour
{
    public Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }
}
