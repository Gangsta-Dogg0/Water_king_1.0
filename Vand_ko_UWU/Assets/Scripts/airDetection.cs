using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airDetection : MonoBehaviour
{
    public airBar airBar;
    public float airRegenRate = 4.20f;

    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            airBar.suficationAmount = airRegenRate;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            airBar.suficationAmount = -airRegenRate;
        }
    }
    void Update()
    {

    }
}
