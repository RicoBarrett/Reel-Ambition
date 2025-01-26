using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenElevator : MonoBehaviour
{
    public bool open;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        open = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        open = false;
    }
}
