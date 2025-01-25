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

    public void SpawnPlayer(Vector3 pos)
    {
        Instantiate(player, pos, Quaternion.identity);
    }
}
