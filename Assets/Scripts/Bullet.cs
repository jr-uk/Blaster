using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float despawnTimer;
    // Start is called before the first frame update
    void Update()
    {
        StartCoroutine(WaitToDespawnBullet());
    }
    IEnumerator WaitToDespawnBullet()
    {
        yield return new WaitForSeconds(despawnTimer);
        Destroy(gameObject);
    }
}
