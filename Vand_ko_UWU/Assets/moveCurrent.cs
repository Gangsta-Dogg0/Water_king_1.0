using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCurrent : MonoBehaviour
{
    public float currentSpeed = 5f;
    public bool rigth;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (rigth == true)
        {
            transform.position += new Vector3(currentSpeed * Time.deltaTime, 0);
        }
        if (rigth == false)
        {
            transform.position -= new Vector3(currentSpeed * Time.deltaTime, 0);
        }
    }
}
