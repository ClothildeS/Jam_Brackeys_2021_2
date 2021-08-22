using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{

    // For now the movement is constant to the right, must be via nav mesh agent later
    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.tag == "MonsterDestroy")
        {
            Destroy(other.collider.gameObject);
        }


    }
}
