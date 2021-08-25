using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSound : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string PlayerStateEvent = "";
    FMOD.Studio.EventInstance playerState;

    public void PlaySound()
    {
        playerState = FMODUnity.RuntimeManager.CreateInstance(PlayerStateEvent);
        playerState.start();
    }
}
