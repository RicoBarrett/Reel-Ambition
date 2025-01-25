using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Awake()
    {

    }
     
    public void LoadLevel()
    {
        GetComponent<Health>().ResetHealth();
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void OnLevelWasLoaded(int level)
    {
        GetComponent<Health>().Start();

    }
}
