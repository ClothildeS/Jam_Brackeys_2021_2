using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string MusicSound = "";


    FMOD.Studio.EventInstance musicInst;

    [SerializeField]
    [Range(0f, 100f)]
    private float fame;

    private void Start()
    {
        musicInst = FMODUnity.RuntimeManager.CreateInstance(MusicSound);
        musicInst.start();
        musicInst.release();
    }

    private void Update()
    {
        musicInst.setParameterByName("Fame", ScoreManager.fameScore);
    }
}
