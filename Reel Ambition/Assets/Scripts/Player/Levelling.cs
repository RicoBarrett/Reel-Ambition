using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelling : MonoBehaviour
{
    public int level;
    public GameObject player;
    public PlayerMovement playerMovement;
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
    public RuntimeAnimatorController levelFour;
    public Sprite levelFourSprite;


    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        //level = manager.GetComponent<PermanentPowers>().playerLevel;
        animator = this.GetComponent<Animator>();
        player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovement>();

        if (level == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelZeroSprite;
            animator.runtimeAnimatorController = levelZero;
        }
        if (level == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelOneSprite;
            animator.runtimeAnimatorController = levelOne;
            playerMovement.jumpCountCount = 2;
        }
        if (level == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelTwoSprite;
            animator.runtimeAnimatorController = levelTwo;
            playerMovement.speed = 8f;
            playerMovement.jumpCountCount = 2;

        }
        if (level == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelThreeSprite;
            animator.runtimeAnimatorController = levelThree;
            playerMovement.dashSpeed = 15f;
            playerMovement.speed = 8f;
            playerMovement.jumpCountCount = 2;
        }
        if (level == 4)
        {
            this.GetComponent<SpriteRenderer>().sprite = levelFourSprite;
            animator.runtimeAnimatorController = levelFour;
            playerMovement.dashSpeed = 15f;
            playerMovement.speed = 8f;
            playerMovement.jumpCountCount = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
