using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool flowerPicked;
    public GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");

        CheckGameController();

        SpawnPlayer();
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

    public void SpawnPlayer()
    {
        player.transform.position = GameObject.Find("SpawnLocation").transform.position;
    }
}
