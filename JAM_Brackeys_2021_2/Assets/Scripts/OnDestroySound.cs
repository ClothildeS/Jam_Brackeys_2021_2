using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroySound : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string destroyedSound = "";

    FMOD.Studio.EventInstance destroyInst;


    private void OnDestroy()
    {
        destroyInst = FMODUnity.RuntimeManager.CreateInstance(destroyedSound);
        destroyInst.start();
    }
}
