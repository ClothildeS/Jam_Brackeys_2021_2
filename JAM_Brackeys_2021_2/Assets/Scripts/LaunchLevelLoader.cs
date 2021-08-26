using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchLevelLoader : MonoBehaviour
{

    public void LaunchNextLevel()
    {
        GameObject.Find("LevelLoader").GetComponent<LevelLoader>().LoadNextLevel();
    }
}
