using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float minigunDelay;
    public bool minigunCanShoot;
    Movement refScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && minigunCanShoot.Equals(true))
        {
            Debug.Log("Pressed left click.");
            Rigidbody2D bulletCopy;
            bulletCopy = Instantiate(bullet, transform.position, transform.rotation);
            GetComponent<Movement>().velocity = new Vector3();
            minigunCanShoot = false;
            StartCoroutine(WaitToShoot());
        }
    }
    IEnumerator WaitToShoot()
    {
        yield return new WaitForSeconds(minigunDelay);
        minigunCanShoot = true;
    }
}


