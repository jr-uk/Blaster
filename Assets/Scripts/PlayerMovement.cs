using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    private Vector2 motion;
    public GameObject player;
    public Transform playerForwardWall;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //messwwwww with physics
    // move the player
    void FixedUpdate()
    {
        //Simple up down
        if(transform.position.y <= 4.5f && transform.position.y >= -4.5f)
        {
            motion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            transform.Translate(motion * speed * Time.deltaTime);

        }
        else 
        {
            //Debug.Log("Player Y: " + player.transform.position.y);
            if (player.transform.position.y > 4.5f)
            {
 
                motion = new Vector2(motion.x,  -0.1f);
                transform.Translate(motion * speed * Time.deltaTime);
            }
            else if (player.transform.position.y < -4.5f)
            {
                motion = new Vector2(motion.x, 0.1f);
                transform.Translate(motion * speed * Time.deltaTime);
            }
            
        }
        
        //if off to the left of the screen
        if (player.transform.position.x < playerForwardWall.transform.position.x - 9f)
        {
            transform.position = new Vector3((playerForwardWall.transform.position.x - 9f) + 0.01f, transform.position.y);
            motion = new Vector2(2f, motion.y);
            transform.Translate(motion * speed * Time.deltaTime);
        }
        //if got past the middle of the camera
        else if (player.transform.position.x > playerForwardWall.transform.position.x)
        {
            motion = new Vector2(-2f, motion.y);
            transform.Translate(motion * speed * Time.deltaTime);
        }




    }
}
