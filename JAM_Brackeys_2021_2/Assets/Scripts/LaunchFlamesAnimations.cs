using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchFlamesAnimations : MonoBehaviour
{
    public void PlayFlames()
    {
        GameObject.Find("FlamesTransition").GetComponent<Animator>().SetTrigger("StartTransition");
    }
}
