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
    public Collider2D playerColider;
    bool isGrounded;

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
    void Update()
    {
        direction = horuzontalinput.ReadValue<float>();
        jumped = jumpInput.ReadValue<float>();
        Debug.Log(playerColider.IsTouchingLayers(6));
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(direction*movespeed, 0));
        bool test = playerColider.IsTouchingLayers(6);
        
        if (jumped == 1 && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpspeed));
        }

    }

}
