using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsCollision : MonoBehaviour
{

    public GameObject footstepsScript;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision detected from monster with " + other.collider.name);
        // Update footsteps material
        if (other.collider.GetComponent<SetFootstepsMaterial>() != null)
        {
            footstepsScript.GetComponent<Footsteps>().groundMaterial = other.collider.GetComponent<SetFootstepsMaterial>().materialName;
        }

    }
}
