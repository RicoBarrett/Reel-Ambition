using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator engineAnimator;
    private GameObject player;

    public PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        engineAnimator = GetComponent<Animator>();

        playerMovement = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeAnimation();
    }

    // Change animation based of Idle bool
    void ChangeAnimation()
    {
        if (playerMovement.jumpAnimation == true)
        {

            engineAnimator.SetTrigger("JumpingTrigger");

        }

        if (playerMovement.jumpAnimation == false)
        {
            engineAnimator.ResetTrigger("JumpingTrigger");

        }

        if (playerMovement.running == true)
        {

            engineAnimator.SetTrigger("RunningTrigger");

        }

        if (playerMovement.running == false)
        {
            engineAnimator.ResetTrigger("RunningTrigger");

        }

        if (playerMovement.falling == true)
        {

            engineAnimator.SetTrigger("FallingTrigger");

        }

        if (playerMovement.falling == false)
        {
            engineAnimator.ResetTrigger("FallingTrigger");

        }

        if (playerMovement.hurt == true)
        {

            engineAnimator.SetTrigger("HurtTrigger");

        }

        if (playerMovement.hurt == false)
        {
            engineAnimator.ResetTrigger("HurtTrigger");

        }
    }
}
