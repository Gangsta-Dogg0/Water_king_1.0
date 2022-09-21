using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraStop : MonoBehaviour
{

    float y = -1;
    public Transform player;
    void Start()
    {
        
    }

    void Update()
    {
        float x = player.position.x;
        

        //why math dont work pls help???? :( <--- me rn because of it dont work
        x = Mathf.Clamp(x, -19, 19);
        if (player.position.y > this.transform.position.y + 4.86f)
        {
            y += 10;
        }
        if (player.position.y < this.transform.position.y - 4.86f)
        {
            y -= 10;
        }

        transform.position = new Vector3(x, y,-10);
    }
}
