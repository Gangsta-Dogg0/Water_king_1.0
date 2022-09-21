using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class signOpen : MonoBehaviour
{
    public GameObject sign;
    public GameObject pressButton;
    public InputAction signOpener;


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
        if(Input.GetKeyDown(KeyCode.F))
        {
            pressButton.SetActive(false);
            sign.SetActive(true);
        }
 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sign.SetActive(false);
        pressButton.SetActive(false);
    }

}
