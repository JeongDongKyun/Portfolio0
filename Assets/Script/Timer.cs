using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float set_timer = 0;

    private Text timer_text = null;

    private float time = 0;
    private float timer = 0;

    private void Awake()
    {
        timer_text = this.GetComponent<Text>();
    }

    private void Start()
    {
        time = Time.time;

        timer_text.text = set_timer.ToString("F0");
    }

    private void Update()
    {
        if (timer >= 0)
        {
            float result_timer = Time.time - time;

            timer = set_timer - result_timer;

            SyncTimerUI();
        }
        else
        {
            GameOut();
        }
    }

    private void SyncTimerUI()
    {
        if (timer <= 10)
        {
            timer_text.color = Color.red;
        }

        timer_text.text = timer.ToString("F0");
    }

    private void GameOut()
    {
        Debug.Log("게임 아웃");

        SceneManager.LoadScene("Lobby");
    }
}