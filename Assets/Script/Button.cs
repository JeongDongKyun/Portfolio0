using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void GameStart()
    {
        Debug.Log("게임 시작");

        SceneManager.LoadScene("Game");
    }

    public void GameExit()
    {
        Debug.Log("게임 종료");

        Application.Quit();
    }

    public void GameBack()
    {
        Debug.Log("로비 이동");

        SceneManager.LoadScene("Lobby");
    }
}