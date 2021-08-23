using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // when an object destroyable by aspiration hit the destroy point, it's destroyed
        if (other.gameObject.GetComponent<Sensitivities>() != null)
        {

            if (other.gameObject.GetComponent<Sensitivities>().destroyedByAspiration == true)
            {
                Destroy(other.gameObject);
            }
        }

    }
}
