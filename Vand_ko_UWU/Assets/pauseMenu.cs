using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    

    public void Resume()
    {
        print("hi");
        Time.timeScale = 1;
        this.gameObject.SetActive(false);
    }
    public void Restart()
    {

    }
    public void Settings()
    {

    }
    public void Quit()
    {
        
    }
}
