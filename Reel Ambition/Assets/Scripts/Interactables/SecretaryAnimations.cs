using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretaryAnimations : MonoBehaviour
{
    public RuntimeAnimatorController controller;
    public Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>().runtimeAnimatorController = controller;
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (manager.flowerPicked == true)
            {
                StartCoroutine(Animation());
                manager.flowerPicked = false;
            }
        }
    }

    IEnumerator Animation()
    {
        this.GetComponent<Animator>().SetTrigger("LoveTrigger");
        yield return new WaitForSeconds(1.3f);
        this.GetComponent<Animator>().ResetTrigger("LoveTrigger");
    }
}
