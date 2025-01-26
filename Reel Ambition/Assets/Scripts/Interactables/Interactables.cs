using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private PlayerMovement playerMovement;
    private Manager manager;
    public float temp;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        temp = Time.timeScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.CompareTag("Soda"))
            {
                playerBody.velocity = new Vector2(playerBody.velocity.x, playerBody.velocity.y + 15);
                Destroy(gameObject);
            }

            if (this.CompareTag("Coffee"))
            {
                StartCoroutine(CoffeeEffect());
            }

            if (this.CompareTag("Flower"))
            {
                manager.flowerPicked = true;
                Destroy(gameObject);
            }
        }
    }

    IEnumerator CoffeeEffect()
    {
        Time.timeScale = 0.8f;
        playerMovement.speed = 6f;
        yield return new WaitForSeconds(5f);
        Time.timeScale = 1f;
        playerMovement.speed = 5f;
        Destroy(gameObject);
    }
}
