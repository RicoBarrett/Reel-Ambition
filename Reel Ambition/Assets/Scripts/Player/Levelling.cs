using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelling : MonoBehaviour
{
    public int level;
    public GameObject manager;
    public Animator animator;
    public RuntimeAnimatorController levelZero;
    public Sprite levelZeroSprite;
    public RuntimeAnimatorController levelOne;
    public Sprite levelOneSprite;
    public RuntimeAnimatorController levelTwo;
    public Sprite levelTwoSprite;
    public RuntimeAnimatorController levelThree;
    public Sprite levelThreeSprite;


    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        level = manager.GetComponent<PermanentPowers>().playerLevel;
        animator = this.GetComponent<Animator>();

        if (level == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelZeroSprite;
            animator.runtimeAnimatorController = levelZero;
        }
        if (level == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelOneSprite;
            animator.runtimeAnimatorController = levelOne;
        }
        if (level == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelTwoSprite;
            animator.runtimeAnimatorController = levelTwo;
        }
        if (level == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelThreeSprite;
            animator.runtimeAnimatorController = levelThree;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
