using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject projectile;
    public float shootSpeed = 1f;
    public float shootForce = 120f;
    private float shootFrequency;
    private float counter;

    private void Update()
    {
        shootFrequency = 1 / shootSpeed;

        counter += Time.deltaTime;

        if (counter >= shootFrequency)
        {
            // Instantiate projectile and give it a force
            GameObject projectileLaunched = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            projectileLaunched.GetComponent<Rigidbody2D>().AddForce(transform.right * shootForce);

            counter = 0;
        }
    }

}
