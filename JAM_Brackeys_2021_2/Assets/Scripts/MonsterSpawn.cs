using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject monster;
    public float appearanceSpeed = 1f;
    public float appearanceForce = 120f;
    public int maximumMonster = 5;
    private float appearanceFrequency;
    private float counter;
    private int monsterNumber = 0;

    private void Update()
    {
        appearanceFrequency = 1 / appearanceSpeed;

        counter += Time.deltaTime;

        if (counter >= appearanceFrequency && monsterNumber != maximumMonster)
        {
            // Instantiate projectile and give it a force
            GameObject projectileLaunched = Instantiate(monster, transform.position, Quaternion.identity) as GameObject;
            projectileLaunched.GetComponent<Rigidbody2D>().AddForce(transform.right * appearanceForce);

            counter = 0;
            monsterNumber = monsterNumber + 1;
        }
    }

}
