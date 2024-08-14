using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private Score score = null;

    private Animator ar = null;

    public void Awake()
    {
        ar = score.GetComponent<Animator>();
    }

    public void OnClick()
    {
        ar.Play("ScoreTextAM", 0, 0);

        score.SetScore(1);
        score.ColorEffect();
        score.SyncScoreUI();
    }
}