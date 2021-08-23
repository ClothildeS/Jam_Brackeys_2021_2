using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensitivities : MonoBehaviour
{
    public bool destroyedByProjectile;
    public bool destroyedByMonster;
    public bool destroyedByGaz;
    public bool destroyedByAspiration;
    public bool destroyedByFire;

    public float health = 10f;



    private void Update()
    {
        // if health of gameobject equals or is below zero, destroy itself
        if (health <= 0)
        {
            Destroy(gameObject);
        }


    }

    public void TakeDamage(float hitDamage)
    {
        health = health - hitDamage;
    }

    private void OnParticleCollision(GameObject other)
    {
        // Debug.Log("Target senses collision with particle");
        TakeDamage(1);
    }


}
