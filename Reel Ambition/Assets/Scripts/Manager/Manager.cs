using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool flowerPicked;
    public Vector3 spawnPosition;
    public GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");

        CheckGameController();

        flowerPicked = false;

        player.transform.position = spawnPosition;
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
