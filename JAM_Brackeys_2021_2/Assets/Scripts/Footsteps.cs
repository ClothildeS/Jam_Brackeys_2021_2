using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public bool sound3D = false;

    public string groundMaterial;
    private float material;

    [FMODUnity.EventRef]
    public string footstepEvent = "";
    FMOD.Studio.EventInstance footstepInst;

    public void PlaySound()
    {
        footstepInst = FMODUnity.RuntimeManager.CreateInstance(footstepEvent);
        if (sound3D)
        {
            footstepInst.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject.transform));
        }
        footstepInst.setParameterByName("Footsteps", material);
        footstepInst.start();
    }
    private void Update()
    {
        if (groundMaterial != null)
        {
            if (groundMaterial == "Stone")
            {
                material = 1;
            }
            else
            {
                material = 0;
            }
        }
    }
}


