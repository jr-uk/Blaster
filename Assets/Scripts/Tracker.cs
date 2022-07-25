using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public Transform trackedObject;
    public float updateSpeed = 3;
    public Vector2 trackingOffset;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //not using
        offset = (Vector3)trackingOffset;
    }

    // slow update to make it smooth
    void LateUpdate()
    {
        //moves the camera to the tracker object location but stays on the same y coords
        //z is set to highest layer
        if(trackedObject.position.x > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(trackedObject.position.x, transform.position.y, -10f), updateSpeed * Time.deltaTime);
        }
        
        
    }
}
