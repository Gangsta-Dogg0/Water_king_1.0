using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class writeLine : MonoBehaviour
{
    public GameObject textBox;
    public GameObject pressF;
    public InputAction textOpener;
    public string textToWrite;
    public TextMeshProUGUI textObject;
    

    private float textOpend;

    private void OnEnable()
    {
        textOpener.Enable();
    }

    private void OnDisable()
    {
        textOpener.Disable();
    }

    void Update()
    {
        textOpend = textOpener.ReadValue<float>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pressF.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            pressF.SetActive(false);
            textObject.text = textToWrite;
            textBox.SetActive(true);

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        textBox.SetActive(false);
        pressF.SetActive(false);
    }
}
