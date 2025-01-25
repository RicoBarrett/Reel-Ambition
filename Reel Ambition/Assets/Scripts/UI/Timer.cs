using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text text;

    SceneController sceneController;

    double time = 9.00;
    float timer = 0;
    int check = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<TMP_Text>();
        sceneController = GameObject.FindWithTag("Manager").GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            timer = 0;
            check += 1;

            if (check >= 6)
            {
                time += .5;
                check = 0;
            }
            else
                time += .1;
        }

        textUpdate();

        if (time >= 17)
        {
            sceneController.LoadLevel();
        }
    }

    void textUpdate() 
    {
        text.text = time.ToString("00.00");
    }
}
