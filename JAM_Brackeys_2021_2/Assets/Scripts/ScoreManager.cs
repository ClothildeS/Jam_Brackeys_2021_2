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
        // fameScore = score;
        if (scoreSlider != null)
        {
            scoreSlider.value = Mathf.Clamp(fameScore, 0, 100);
        }



        if (fameScore >= 100)
        {

            // launch chaos animation
            GameObject.Find("Chaos_All").GetComponent<Animator>().SetTrigger("Chaos_Appearance");


        }
    }
}
