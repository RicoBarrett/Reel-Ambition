using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMoney : MonoBehaviour
{
    public Score score;
    public int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Manager").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ScoreIncrease());
        }
    }

    IEnumerator ScoreIncrease()
    {
        score.ScoreIncrease(scoreValue);
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
