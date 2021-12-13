using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{public float speed;
private CharacterController Controller;
private Vector3 playerVelocity;
private bool grundedPlayer;
private float playerSpeed = 2.0f;
private float jumpHeight = 1.0f;
private float gravityVlaue = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        Controller = gameObject. AddComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //float h = Input . GetAxisRaw("Horizontal");
        //float v = Input . GetAxisRaw("Vertical");

        //gameObject . transform.position = new Vector2 (transform.position.x + (h * speed),
        //transform.position.y + (v * speed));
    }
}
