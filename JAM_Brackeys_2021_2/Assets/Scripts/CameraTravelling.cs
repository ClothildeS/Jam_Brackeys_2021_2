using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTravelling : MonoBehaviour
{
    public float speed = 2f;
    private float xMov = 0f;
    private float xPos = 0f;

    private void Update()
    {
        // If a arrow direction is pressed, move the camera along the x axis
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            xMov = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            xPos = transform.position.x + xMov;
            transform.position = new Vector3(Mathf.Clamp(xPos, -18, 60), 0, transform.position.z);
        }
    }

}
