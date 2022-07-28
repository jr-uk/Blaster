using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float minigunDelay;
    public bool minigunCanShoot;
    public int minigunBulletSpeed;
    public int bulletDespawn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && minigunCanShoot.Equals(true))
        {
            Rigidbody2D bulletCopy;
            bulletCopy = Instantiate(bullet, transform.position, transform.rotation);
            bulletCopy.velocity = new Vector3(minigunBulletSpeed, 0, 0);
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


