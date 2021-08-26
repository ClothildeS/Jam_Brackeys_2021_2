using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static float fameScore;
    public Slider scoreSlider;
    public float score;

    private void Start()
    {
        fameScore = 0;
    }

    private void Update()
    {
        fameScore = score;
        scoreSlider.value = Mathf.Clamp(fameScore, 0, 100);
    }
}