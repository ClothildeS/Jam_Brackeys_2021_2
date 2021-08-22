using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDeath : MonoBehaviour
{
    public float lifeTime = 6;
    private float counter;

    // The projectile destroys itself when colliding with something, but if it is something it can destroy,
    // it will destroy the collider object
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.tag == "ProjectileDestroy")
        {
            Destroy(other.collider.gameObject);
        }

        Destroy(gameObject);

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
