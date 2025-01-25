using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    bool pause = false;

    [SerializeField]
    GameObject Hud;

    [SerializeField]
    GameObject PauseMenu;

    [SerializeField]
    GameObject MainMenu;

    public void Start()
    {
        Hud = GameObject.Find("HUD");
        PauseMenu = GameObject.Find("Pause");
        MainMenu = GameObject.Find("MainMenu");

        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            Hud.SetActive(false);
            PauseMenu.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().name == "Demo Level") 
        {
            PauseMenu.SetActive(false);
            MainMenu.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.Escape) && !pause)
        {
            Debug.Log("pause");
            PauseGame();
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && pause)
        {
            UnPauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0.0f;
        pause = true;

        Hud.SetActive(false);
        PauseMenu.SetActive(true);

    }

    public void UnPauseGame()
    {
        Time.timeScale = 1.0f;
        pause = false;

        Hud.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void Quit()
    {
        GameObject.Find("Manager").GetComponent<SceneController>().Quit();
    }

    public void Play()
    {
        GameObject.Find("Manager").GetComponent<SceneController>().LoadLevel();
    }

    public void ButtonAnimationOne()
    {
        Animator animation = GameObject.Find("Quit").GetComponent<Animator>();
        animation.SetBool("Hover", true);
    }

    public void ButtonAnimationTwo()
    {
        Animator animation = GameObject.Find("Play").GetComponent<Animator>();
        animation.SetBool("Hover", true);
    }

    public void ButtonAnimationThree()
    {
        Animator animation = GameObject.Find("Resume").GetComponent<Animator>();
        animation.SetBool("Hover", true);
    }

    public void EndButtonAnimation()
    {

    }
}
