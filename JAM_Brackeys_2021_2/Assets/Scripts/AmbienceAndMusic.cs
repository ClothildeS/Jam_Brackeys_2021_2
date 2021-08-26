using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceAndMusic : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string Ambience = "";
    [FMODUnity.EventRef]
    public string Music = "";

    FMOD.Studio.EventInstance ambienceInst;
    FMOD.Studio.EventInstance musicInst;

    [SerializeField]
    [Range(0f, 100f)]
    private float fame;

    private void Start()
    {
        ambienceInst = FMODUnity.RuntimeManager.CreateInstance(Ambience);
        ambienceInst.start();
        musicInst = FMODUnity.RuntimeManager.CreateInstance(Music);
        musicInst.start();
    }

    private void Update()
    {
        ambienceInst.setParameterByName("Fame", ScoreManager.fameScore);
        musicInst.setParameterByName("Fame", ScoreManager.fameScore);
    }

}
