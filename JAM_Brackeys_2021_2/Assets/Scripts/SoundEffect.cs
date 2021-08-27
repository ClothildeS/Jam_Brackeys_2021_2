using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string Sound = "";




    FMOD.Studio.EventInstance soundInst;



    private void Start()
    {
        soundInst = FMODUnity.RuntimeManager.CreateInstance(Sound);
        soundInst.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject.transform));
        soundInst.start();
        soundInst.release();
    }

}
