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
        if (level == 0)
        {
            GetComponent<Health>().enabled = false;
        }
        else if(level == 1)
        {
            GetComponent<Health>().enabled = true;

            GetComponent<Manager>().SpawnPlayer(GameObject.Find("SpawnLocation").transform.position);
            GetComponent<Manager>().flowerPicked = false;
        }

    }
}
