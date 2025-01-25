using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPassthrough : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.S))
            {
                StartCoroutine(Passthrough());
            }
        }
    }

    IEnumerator Passthrough()
    {
        gameObject.transform.parent.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(0.6f);
        gameObject.transform.parent.gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
