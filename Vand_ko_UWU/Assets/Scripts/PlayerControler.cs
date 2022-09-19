using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float movementSpeed = 69f;
    public float jumpHeigth = 40;

    public Collider2D groundCheck;

    private Vector2 velocity;


    private void FixedUpdate() {

        //moves the player on the x axis
        velocity.x = Input.GetAxis("Horizontal") * movementSpeed;

        //moves the player on the y axis
        if (Input.GetButtonDown("Jump") && groundCheck.IsTouchingLayers(6))
        {
            print("hi");
        }

        playerRB.AddForce(velocity * Time.deltaTime);
    }

}
