using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Health : MonoBehaviour
{
    GameObject PlayerBubble;

    [SerializeField]
    GameObject[] bubbles;

    [SerializeField]
    int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        bubbles = new GameObject[10];

        if (bubbles == null || bubbles.Length != 10)
        {
            Debug.LogError("Bubbles array is not properly initialized.");
            return;
        }
        for (int i = 0; i < 10; i++)
        {
            string name = "Bubble (" + (i+1) + ")";
            bubbles[i] = GameObject.Find(name);
            if (bubbles[i] == null)
            {
                Debug.LogError("Bubble (" + i + ") not found!");
            }
        }
        PlayerBubble = GameObject.Find("PlayerBubble");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        int check = health / 10;

        for (int i = 0; i < bubbles.Length; i++)
        {
            Animator animator = bubbles[i].GetComponentInChildren<Animator>();

            if (check < i)
                animator.SetBool("Pop", true);
            else
                animator.SetBool("Pop", false);
        }
    }

    public void ReduceHealth(int minus)
    {
        health -= minus;
    }

    public void increaseHealth(int plus)
    {
        health += plus;
    }

    public void ResetHealth()
    {
        health = 100;
    }
}
