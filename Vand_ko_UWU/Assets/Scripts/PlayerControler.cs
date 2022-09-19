using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float movementSpeed = 69f;
    public float jumpHeigth = 40;

    private Vector2 velocity;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void FixedUpdate() {

        //moves the player on the x axis
        velocity.x = Input.GetAxis("Horizontal") * movementSpeed;

        //moves the player on the y axis
        if (Input.GetKey("Jump")){
            velocity.y = jumpHeigth;
        }
        else
        {
            velocity.y = 0;
        }

        playerRB.AddForce(velocity * Time.deltaTime);
    }
}
