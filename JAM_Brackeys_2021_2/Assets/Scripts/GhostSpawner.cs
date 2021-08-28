using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;
    private Vector3 ghostPos;
    public float xOffset;

    private void Update()
    {
        if (GetComponent<Sensitivities>().health <= 0)
        {
            SpawnGhost();
        }
    }
    public void SpawnGhost()
    {
        ghostPos = new Vector3(transform.position.x + xOffset, Mathf.Clamp(transform.position.y, -6, -4), 0);
        Instantiate(ghostPrefab, ghostPos, Quaternion.identity);
    }
}
