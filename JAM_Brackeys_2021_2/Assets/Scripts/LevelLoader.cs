using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    FMOD.Studio.Bus AllSoundsBus;

    private void Start()
    {

        AllSoundsBus = FMODUnity.RuntimeManager.GetBus("Bus:/AllSounds");
    }
    private void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        // Stop All sounds
        AllSoundsBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
