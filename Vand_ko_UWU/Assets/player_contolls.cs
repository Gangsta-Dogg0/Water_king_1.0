using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class player_contolls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed = 5f;
    public float jumpspeed = 50f;
    public InputAction horuzontalinput;
    public InputAction jumpInput;
    public Collider2D playerCol;

    private float direction; //
    private float jumped; //
    private bool hasjumped = false; //

    private void OnEnable()
    {
        horuzontalinput.Enable();
        jumpInput.Enable();
    }

    private void OnDisable()
    {
        horuzontalinput.Disable();
        jumpInput.Disable();
    }

    void Update()
    {
        direction = horuzontalinput.ReadValue<float>();
        jumped = jumpInput.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(direction*movespeed, 0));

        if (jumped == 1 && playerCol.IsTouchingLayers(6))
        {
            rb.AddForce(new Vector2(0, jumpspeed));
            hasjumped = true;
        }
        else if (jumped == 0){
            hasjumped = false;
        }

    }

}
