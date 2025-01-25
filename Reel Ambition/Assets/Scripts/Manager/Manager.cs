using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        CheckGameController();

    }

    void CheckGameController()
    {
        GameObject[] gameManager = GameObject.FindGameObjectsWithTag("Manager");
        if(gameManager.Length > 1)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(gameObject);
    }
}
