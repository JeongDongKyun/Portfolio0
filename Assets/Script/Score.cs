using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text score_text = null;

    private int score = 0;

    private void Awake()
    {
        score_text = this.GetComponent<Text>();
    }

    private void Start()
    {
        score_text.text = score.ToString();
    }

    public void SetScore(int value)
    {
        score += value;

        int best_score = PlayerPrefs.GetInt("Score");

        if (score > best_score)
        {
            PlayerPrefs.SetInt("Score", score);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void SyncScoreUI()
    {
        score_text.text = score.ToString();
    }

    public void ColorEffect()
    {
        switch (score)
        {
            case 200:

                score_text.color = Color.red;

                break;

            case 400:

                score_text.color = Color.yellow;

                break;

            case 600:

                score_text.color = Color.green;

                break;

            case 800:

                score_text.color = Color.blue;

                break;
        }
    }
}