using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obscurables : MonoBehaviour
{
    private Renderer renderer;


    [SerializeField]
    protected int[] m_queues = new int[] { 3000 };

    protected void Awake()
    {
        renderer = GetComponent<Renderer>();
        Material[] materials = renderer.materials;
        for (int i = 0; i < materials.Length && i < m_queues.Length; ++i)
        {
            materials[i].renderQueue = m_queues[i];
        }
    }


}
