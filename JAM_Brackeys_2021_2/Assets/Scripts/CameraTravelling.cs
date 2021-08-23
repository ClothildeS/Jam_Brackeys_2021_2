using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTravelling : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
        // If a arrow direction is pressed, move the camera along the x axis
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0));
        }
    }

}
