using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airDetection : MonoBehaviour
{
    public airBar airBar;
    public float airRegenRate = 20f;

    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            airBar.breatheAmount = airRegenRate;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            airBar.breatheAmount = 0;
        }
    }
    void Update()
    {

    }
}
