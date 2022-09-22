using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class player_contolls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed = 5f;
    public float jumpspeed = 50f;
    public float swimSpeed = 20f;
    public float swimSuffication = -10f;
    public InputAction horuzontalinput;
    public InputAction jumpInput;
    public InputAction swimInput;
    public InputAction menuInput;
    public Collider2D playerColider;
    public int health;
    public int invincibilityframes;
    public int invincibilitycooldown;
    bool isGrounded;
    public airBar airBar;
    public GameObject menuObject;
    public AudioSource jumpSound;

    private float direction; //
    private float jumped; //
    private float swim;
    private float menu;
    private bool hasjumped = false; //

    private void OnEnable()
    {
        horuzontalinput.Enable();
        jumpInput.Enable();
        swimInput.Enable();
        menuInput.Enable();
    }

    private void OnDisable()
    {
        horuzontalinput.Disable();
        jumpInput.Disable();
        swimInput.Disable();
        menuInput.Disable();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
    void Update()
    {
        direction = horuzontalinput.ReadValue<float>();
        jumped = jumpInput.ReadValue<float>();
        swim = swimInput.ReadValue<float>();
        menu = menuInput.ReadValue<float>();

        if(menu == 1)
        {
            menuObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(direction * movespeed, 0));
        bool test = playerColider.IsTouchingLayers(6);

        if (jumped == 1 && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpspeed));
            jumpSound.Play();
            hasjumped = true;
        }
        else if (jumped == 0)
        {
            hasjumped = false;
        }

        if (swim == 1)
        {
            rb.AddForce(new Vector2(direction * swimSpeed, jumped * swimSpeed));
            rb.gravityScale = 0.05f;
            airBar.suficationAmount = swimSuffication;
        }
        else if (swim == 0)
        {
            rb.gravityScale = 0.4f;
            airBar.suficationAmount = -4.20f;
        }
    }
    private void OnTiggerStay2D(Collider2D collider)
    {
        if (invincibilitycooldown < 1)
            health -= 1;
        invincibilitycooldown = invincibilityframes;
        if (health == 0)
        {
            Debug.Log("wow det viker!");
        }
    }

    void fixedupdate()
    {


        invincibilitycooldown -= 1;

    }
}
