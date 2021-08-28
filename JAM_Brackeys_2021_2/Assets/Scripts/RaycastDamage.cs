using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDamage : MonoBehaviour
{
    public LayerMask usedLayerMask;

    private void FixedUpdate()
    {
        // Cast a ray
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 10, usedLayerMask);

        // If it hits something
        if (hit.collider != null)
        {
            //Debug.Log("hit something with fire raycast");
            // If collider is sensitive
            if (hit.collider.GetComponent<Sensitivities>() != null)
            {
                if (hit.collider.GetComponent<Sensitivities>().destroyedByFire | hit.collider.GetComponent<Sensitivities>().destroyedByGaz)
                {
                    hit.collider.GetComponent<Sensitivities>().TakeDamage(1);
                }
            }
        }
    }
}
