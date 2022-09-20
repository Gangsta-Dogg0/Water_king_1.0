using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraStop : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    void Update()
    {
        float x = player.position.x;

        //why math dont work pls help???? :( <--- me rn because of it dont work
        x = Mathf.Clamp(x, -19, 19);
        
        transform.position = new Vector3(x,-1,-10);
    }
}
