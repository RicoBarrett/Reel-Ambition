using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Health : MonoBehaviour
{
    [SerializeField]
    GameObject PlayerBubble;

    [SerializeField]
    GameObject[] bubbles;

    [SerializeField]
    int health = 100;

    // Start is called before the first frame update
    public void Start()
    {
        health = 100;

        bubbles = new GameObject[10];

        if (bubbles == null || bubbles.Length != 10)
        {
            Debug.LogError("Bubbles array is not properly initialized.");
            return;
        }

        if (GameObject.Find("Bubble (1)") != null)
        {
            for (int i = 0; i < 10; i++)
            {
                string name = "Bubble (" + (i + 1) + ")";
                bubbles[i] = GameObject.Find(name);
                if (bubbles[i] == null)
                {
                    Debug.LogError("Bubble (" + i + ") not found!");
                }
            }
        }

        if (GameObject.Find("PlayerBubble") != null)
            PlayerBubble = GameObject.Find("PlayerBubble");
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            GetComponent<SceneController>().LoadMenu();
        }
        if (health > 100)
            health = 100;

        
        UpdateHealthBar();
        BubbleShrink();
    }

    void UpdateHealthBar()
    {
        int check = health / 10;
        if (bubbles[0] != null)
        {
            for (int i = 0; i < bubbles.Length; i++)
            {
                Animator animator = bubbles[i].GetComponentInChildren<Animator>();

                if (check < i)
                    animator.SetBool("Pop", true);
                else
                    animator.SetBool("Pop", false);
            }
        }
    }

    public void ReduceHealth(int minus)
    {
        health -= minus;
    }

    public void IncreaseHealth(int plus)
    {
        health += plus;
    }

    public void ResetHealth()
    {
        health = 100;
    }

    public void BubbleShrink()
    {
        float shrink = health / 1000;

        if (PlayerBubble != null)
            PlayerBubble.transform.localScale.Set(shrink, shrink, 0);

    }

}
