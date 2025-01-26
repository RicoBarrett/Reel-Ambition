using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemy : MonoBehaviour
{

    public GameObject PointA;
    public GameObject PointB;
    [SerializeField]
    GameObject Destination;

    GameObject manager;

    Animator animator;

    Rigidbody2D rb;

    bool idle;

    float speed = 3.0f;
    float time = 0;

    bool isFacingRight = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destination = PointA;

        manager = GameObject.Find("Manager");

        animator = GetComponent<Animator>();

        idle = true;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (idle && time > 5)
            Walk();
        else if (!idle)
        {
            moveToDestination();
            if (Mathf.Abs(transform.position.x - Destination.transform.position.x) < 0.5f)
                Idle();
        }

        flipSprite();
    }

    void Walk()
    {
        if (animator != null)
            animator.SetTrigger("Walk");

        idle = false;
    }

    void Idle()
    {
        if (animator != null)
            animator.SetTrigger("Idle");

        idle = true;
        time = 0;

        if(Destination == PointA)
            Destination = PointB;
        else if(Destination == PointB)
            Destination = PointA;
    }

    void moveToDestination()
    {
        Vector2 direction = (Destination.transform.position - transform.position).normalized;
        rb.velocity = direction * speed;
    }

    void flipSprite()
    {
        if((isFacingRight && rb.velocity.x < 0f) || (!isFacingRight && rb.velocity.x > 0f))
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = GameObject.Find("SpawnLocation").transform.position;
        }
    }
}
