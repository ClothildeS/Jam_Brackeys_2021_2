using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;
    private Vector3 ghostPos;

    private void OnDestroy()
    {
        ghostPos = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -7, -4), 0);
        Instantiate(ghostPrefab, ghostPos, Quaternion.identity);
    }
}
