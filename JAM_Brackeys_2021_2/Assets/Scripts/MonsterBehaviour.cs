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
        // If the collider can be destroyed and is sensitive to monsters, destroy it at collision
        if (other.collider.GetComponent<Sensitivities>() != null)
        {
            if (other.collider.GetComponent<Sensitivities>().destroyedByMonster == true)
            {
                other.gameObject.GetComponent<Sensitivities>().TakeDamage(50);
            }

        }


    }
}
