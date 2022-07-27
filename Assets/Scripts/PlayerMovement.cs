using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    private Vector2 motion;
    public GameObject player;
    public Transform playerForwardWall;

    // Update is called once per frame
    void Update()
    {
        //Simple up down
        if (transform.position.y < 4.5f && transform.position.y > -4.5f)
        {
            motion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            transform.Translate(motion * speed * Time.deltaTime);

        }
        else
        {
            if (player.transform.position.y > 4.5f)
            {
                transform.position = new Vector3(transform.position.x, 4.499f);
            }
            else if (player.transform.position.y < -4.5f)
            {
                transform.position = new Vector3(transform.position.x, -4.499f);
            }

        }

        //if off to the left of the screen
        if (player.transform.position.x < playerForwardWall.transform.position.x - 9f)
        {
            transform.position = new Vector3((playerForwardWall.transform.position.x - 9f) + 0.01f, transform.position.y);
        }
        //if got past the middle of the camera
        else if (player.transform.position.x > playerForwardWall.transform.position.x)
        {
            transform.position = new Vector3(playerForwardWall.transform.position.x - 0.01f, transform.position.y);
        }
    }
}
