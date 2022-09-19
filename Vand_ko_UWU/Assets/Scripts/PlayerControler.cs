using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float movementSpeed = 69f;
    public float jumpHeigth = 40;
    public float jumpLength = 20;

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
        if (Input.GetKeyDown(KeyCode.W)){
            SetJump();
        }

        playerRB.AddForce(velocity * Time.deltaTime);
    }

    private void SetJump()
    {
        for (int i = 5; i < -jumpLength; i--)
        {
            velocity.y = jumpLength * (i * i) * jumpHeigth;
            print(velocity.y * Time.deltaTime);
        }

    }
}
