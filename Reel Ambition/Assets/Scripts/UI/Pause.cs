using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool pause = false;

    [SerializeField]
    GameObject Hud;

    [SerializeField]
    GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        Hud = GameObject.Find("HUD");
        PauseMenu = GameObject.Find("Pause");

        PauseMenu.SetActive(false);
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
}
