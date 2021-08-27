using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSound : MonoBehaviour
{
    public bool sound3D = false;

    [FMODUnity.EventRef]
    public string PlayerStateEvent = "";
    FMOD.Studio.EventInstance playerState;

    public void PlaySound()
    {
        playerState = FMODUnity.RuntimeManager.CreateInstance(PlayerStateEvent);
        if (sound3D)
        {
            playerState.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject.transform));
        }
        playerState.start();
    }
}
