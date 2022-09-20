using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraStop : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

        Mathf.Clamp(transform.position.x, -21, 21);
        Mathf.Clamp(transform.position.y, -21, 21);
    }
}
