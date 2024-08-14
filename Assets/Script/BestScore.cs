using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    Text best_score_text = null;

    private void Awake()
    {
        best_score_text = this.GetComponent<Text>();
    }

    private void Start()
    {
        int score = PlayerPrefs.GetInt("Score");

        best_score_text.text = score.ToString();
    }
}
