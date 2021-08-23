using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDeath : MonoBehaviour
{
    public float lifeTime = 6;
    private float counter;


    private void OnCollisionEnter2D(Collision2D other)
    {

        // If the collider can be destroyed and is sensitive to projectiles, destroy it at collision
        if (other.collider.GetComponent<Sensitivities>() != null)
        {

            if (other.collider.GetComponent<Sensitivities>().destroyedByProjectile == true)
            {

                Destroy(other.collider.gameObject);
            }

            Destroy(gameObject);
        }
    }

    private void Update()
    {
        counter += Time.deltaTime;

        // if the projectile hasn't collide with something and its lifetime has pass, it dies
        if (counter > lifeTime)
        {
            //Debug.Log("Projectile's lifetime expired");
            Destroy(gameObject);
        }
    }
}
