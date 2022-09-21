using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class signOpen : MonoBehaviour
{
    public GameObject sign;
    public GameObject pressButton;
    public InputAction signOpener;
    private int x = 0;

    private float signOpend;
    private void OnEnable()
    {
        signOpener.Enable();
    }

    private void OnDisable()
    {
        signOpener.Disable();
    }
    private void Update()
    {
        signOpend = signOpener.ReadValue<float>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            pressButton.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKeyDown("f") && x == 0)
        {
            sign.SetActive(true);
            print("i detected");
            x += 1;
            TurnOffSign();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sign.SetActive(false);
        pressButton.SetActive(false);
    }
    void TurnOffSign()
    {
        if (Input.GetKeyDown("f") && x == 1)
        {
            sign.SetActive(false);
            x -= 1;
            print("i exited");
        }
    }
}
