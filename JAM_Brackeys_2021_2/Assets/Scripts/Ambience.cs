using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambience : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string AmbienceSound = "";




    FMOD.Studio.EventInstance ambienceInst;

    [SerializeField]
    [Range(0f, 100f)]
    private float fame;

    private void Start()
    {
        ambienceInst = FMODUnity.RuntimeManager.CreateInstance(AmbienceSound);
        ambienceInst.start();
        ambienceInst.release();
    }

    private void Update()
    {
        ambienceInst.setParameterByName("Fame", ScoreManager.fameScore);
    }


}
