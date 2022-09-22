using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    public GameObject options;

    public void Resume()
    {
        Time.timeScale = 1;
        this.gameObject.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void Settings()
    {
        options.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
