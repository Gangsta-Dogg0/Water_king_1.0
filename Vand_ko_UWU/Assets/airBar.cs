using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class airBar : MonoBehaviour
{
    public Slider airbar;
    public float air = 50f;
    public float suficationAmount = -4.20f;
    public Gradient gradient;
    public Image colur;

    private float curentAir;

    void Start()
    {
        airbar.value = air;
        curentAir = air;
    }

    void Update()
    {
        curentAir += suficationAmount * Time.deltaTime;
        curentAir = Mathf.Clamp(curentAir, 0, 100);
        airbar.value = curentAir;

        print(curentAir);

        colur.color = gradient.Evaluate(airbar.value / 100);

        if (curentAir <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

}
