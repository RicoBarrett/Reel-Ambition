using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorAnimation : MonoBehaviour
{
    public GameObject elavatorCollider;
    public OpenElevator boxCollider;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        elavatorCollider = GameObject.Find("Collider");
        boxCollider = elavatorCollider.GetComponent<OpenElevator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (boxCollider.open == true)
        {

            animator.SetTrigger("OpenTrigger");

        }

        if (boxCollider.open == false)
        {
            animator.ResetTrigger("OpenTrigger");

        }
    }
}
