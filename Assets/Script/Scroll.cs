using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    private ScrollRect sr;

    private void Awake()
    {
        sr = this.GetComponent<ScrollRect>();
    }

    public void BoxCanvas()
    {
        if (sr.content.anchoredPosition.x >= 100)
        {
            Debug.Log("업데이트 요청");
        }
    }
}