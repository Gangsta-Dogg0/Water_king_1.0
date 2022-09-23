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
    public float breatheAmount = -0f;
    public Gradient gradient;
    public Image colur;
    public Image deathGrade;
    public GameObject deathGradeOject;

    private float curentAir;
    private float grade = 0;

    void Start()
    {
        airbar.value = air;
        airbar.maxValue = air;
        curentAir = air;
    }

    void Update()
    {
        curentAir += suficationAmount * Time.deltaTime;
        curentAir = Mathf.Clamp(curentAir, 0, 100);
        airbar.value = curentAir;

        curentAir += breatheAmount * Time.deltaTime;
        curentAir = Mathf.Clamp(curentAir, 0, 100);
        airbar.value = curentAir;

        colur.color = gradient.Evaluate(airbar.value / 100);
        
        if (curentAir <= 0)
        {
            deathGradeOject.SetActive(true);
            deathGrade.color = new Color(0,0,0, grade);
            if (grade < 1)
            {
                grade += 0.01f;
            } else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
    }
    IEnumerator secondsWaiter()
    {
        yield return new WaitForSecondsRealtime(5f);
    }

}
