using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideMonke : MonoBehaviour
{
    public GameObject sand;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sand.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sand.SetActive(true);
    }
}
