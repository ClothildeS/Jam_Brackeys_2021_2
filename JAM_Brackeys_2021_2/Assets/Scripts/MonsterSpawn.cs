using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject monster;
    public float appearanceSpeed = 1f;
    public float appearanceForce = 120f;
    public int maximumMonster = 3;
    public float xOffset;
    public float yOffset;
    private float appearanceFrequency;
    private float counter;
    private int monsterNumber = 0;

    private void Update()
    {
        appearanceFrequency = 1 / appearanceSpeed;

        counter += Time.deltaTime;

        if (counter >= appearanceFrequency && monsterNumber != maximumMonster)
        {
            Vector3 monsterPos = new Vector3(transform.position.x + xOffset, transform.position.y + yOffset, 0);
            // Instantiate projectile and give it a force
            GameObject projectileLaunched = Instantiate(monster, monsterPos, Quaternion.identity) as GameObject;
            projectileLaunched.GetComponent<Rigidbody2D>().AddForce(transform.right * appearanceForce);

            counter = 0;
            monsterNumber = monsterNumber + 1;
        }
    }

}
