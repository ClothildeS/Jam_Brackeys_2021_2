using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalsSpawner : MonoBehaviour
{
    public static GameObject currentPortal;
    public GameObject projectilePortal;
    public GameObject monsterPortal;

    private Dictionary<string, GameObject> Portals = new Dictionary<string, GameObject>();


    private void Start()
    {
        Portals.Add("projectile", projectilePortal);
        Portals.Add("monster", monsterPortal);
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0) == true)
        {
            if (currentPortal != null)
            {
                // Convert mouse position relative to the screen
                Vector3 mousePos = Input.mousePosition;
                mousePos.z = 2.0f;       // we want 2m away from the camera position
                Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);

                Instantiate(currentPortal, objectPos, Quaternion.identity);
            }
            else
            {
                Debug.Log("Please choose a portal first");
            }

        }
    }

    public void ChoosePortal(string PortalType)
    {

        currentPortal = Portals[PortalType];
    }

}
