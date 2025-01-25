using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideDamage : MonoBehaviour
{
    public int damage;
    public GameObject manager;
    public Health health;
    public CameraShake cameraShake;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        health = manager.GetComponent<Health>();
        cameraShake = GameObject.Find("Main Camera").GetComponent<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cameraShake.shake = true;
            health.ReduceHealth(damage);
        }
    }
}
