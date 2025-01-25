using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreIncrease(int add)
    {
        score += add;
    }

    public void ScoreDecrease(int dec)
    {
        score -= dec;
    }

    public int getScore()
    {
        return score;
    }
}
