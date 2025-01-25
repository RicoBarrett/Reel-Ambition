using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    Score score;

    TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Manager").GetComponent<Score>();
        text = GetComponentInChildren<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textUpdate();
    }

    void textUpdate()
    {
        text.text = "$: " + score.getScore().ToString();
    } 
}
