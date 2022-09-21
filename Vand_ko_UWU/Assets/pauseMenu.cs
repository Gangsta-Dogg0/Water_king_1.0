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
        SceneManager.LoadScene(0);
    }
    public void Settings()
    {
        options.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
