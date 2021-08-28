using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MonsterBehaviour : MonoBehaviour
{

    public Transform monster;
    public Transform target;
    public float speed = 20f;

    public float nextWayPointDistance = 2f;
    Path path;
    int currentWayPoint = 0;
    bool reachEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;

    private void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        target = FindClosestTarget().transform;


        InvokeRepeating("UpdatePath", 0f, 1f);
    }

    void UpdatePath()
    {
        if (seeker.IsDone())
        {
            if (target != null)
            {
                seeker.StartPath(rb.position, target.position, OnPathComplete);
            }

        }

    }

    // For now the movement is constant to the right, must be via nav mesh agent later
    private void FixedUpdate()
    {

        if (GameObject.FindGameObjectsWithTag("MonsterDestroy") == null)
        {
            return;
        }
        target = FindClosestTarget().transform;



        if (path == null)
        {
            return;
        }

        if (currentWayPoint >= path.vectorPath.Count)
        {
            reachEndOfPath = true;
            return;
        }
        else
        {
            reachEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWayPoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWayPoint]);

        if (distance < nextWayPointDistance)
        {
            currentWayPoint++;
        }

        if (force.x >= 0.02f)
        {
            monster.localScale = new Vector3(-0.5f, 0.5f, 1f);
        }
        else if (force.x < -0.02f)
        {
            monster.localScale = new Vector3(0.5f, 0.5f, 1f);
        }

        // Update animations
        if (Mathf.Abs(rb.velocity.x) >= 0.02f)
        {
            GetComponentInChildren<Animator>().SetBool("Running", true);
        }
        else if (Mathf.Abs(rb.velocity.x) < 0.02f)
        {
            GetComponentInChildren<Animator>().SetBool("Running", false);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision detected from monster with " + other.collider.name);

        // If the collider can be destroyed and is sensitive to monsters, destroy it at collision
        if (other.collider.GetComponent<Sensitivities>() != null)
        {
            if (other.collider.GetComponent<Sensitivities>().destroyedByMonster == true)
            {
                other.gameObject.GetComponent<Sensitivities>().TakeDamage(50);
            }

        }

        // if the other collider is a hero, take damage
        if (other.collider.name.Contains("Hero"))
        {
            GetComponent<Sensitivities>().TakeDamage(50);
        }

        // Update footsteps material
        if (other.collider.GetComponent<SetFootstepsMaterial>() != null)
        {
            GetComponentInChildren<Footsteps>().groundMaterial = other.collider.GetComponent<SetFootstepsMaterial>().materialName;
        }


    }

    public void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWayPoint = 0;
        }
    }

    public GameObject FindClosestTarget()
    {

        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("MonsterDestroy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
