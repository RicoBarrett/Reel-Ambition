using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameObject player;
    private Manager manager;

    public Vector3 checkpointPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        manager = GameObject.Find("Manager").GetComponent<Manager>();

        checkpointPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("SpawnLocation").transform.position.Set(checkpointPosition.x, checkpointPosition.y, checkpointPosition.z);

            manager.GetComponent<Health>().ResetHealth();
        }
    }
}
