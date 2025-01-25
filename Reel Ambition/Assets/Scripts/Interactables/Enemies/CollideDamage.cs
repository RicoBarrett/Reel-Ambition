using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideDamage : MonoBehaviour
{
    public int damage;
    public GameObject manager;
    public GameObject player;
    public Health health;
    public CameraShake cameraShake;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        health = manager.GetComponent<Health>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            health.ReduceHealth(damage);
            StartCoroutine(HurtPlayer());
        }
    }

    IEnumerator HurtPlayer()
    {
        player.GetComponent<PlayerMovement>().hurt = true;
        yield return new WaitForSeconds(0.5f);
        player.GetComponent<PlayerMovement>().hurt = false;
    }
}
