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
            for (int i = 1; i < 101; i++)
            {                
                float grade = i;
                grade = grade / 100;
                deathGrade.color = new Color(0, 0, 0, grade);
                print(grade);
                StartCoroutine(secondsWaiter());
            }
            //SceneManager.LoadScene(1);
        }
    }
    IEnumerator secondsWaiter()
    {
        yield return new WaitForSecondsRealtime(5f);
    }

}
