using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PortalsSpawner : MonoBehaviour
{
    public static GameObject currentPortal;
    public GameObject projectilePortal;
    public GameObject monsterPortal;
    public GameObject gazPortal;
    public GameObject aspirationPortal;
    public GameObject firePortal;


    private Dictionary<string, GameObject> Portals = new Dictionary<string, GameObject>();


    private void Start()
    {
        Portals.Add("projectile", projectilePortal);
        Portals.Add("monster", monsterPortal);
        Portals.Add("gaz", gazPortal);
        Portals.Add("aspiration", aspirationPortal);
        Portals.Add("fire", firePortal);

    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0) == true)
        {
            // if the pointer isn't on UI elements
            if (!EventSystem.current.IsPointerOverGameObject())
            {

                if (currentPortal != null)
                {
                    // Convert mouse position relative to the screen
                    Vector3 mousePos = Input.mousePosition;
                    mousePos.z = 20f;       // we want 2m away from the camera position
                    Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
                    objectPos = new Vector3(objectPos.x, objectPos.y, 0);

                    Instantiate(currentPortal, objectPos, currentPortal.transform.rotation);

                }
                else
                {
                    Debug.Log("Please choose a portal first");
                }
            }
            else
            {
                Debug.Log("Can't spawn portals over UI elements");
            }
        }
    }

    public void ChoosePortal(string PortalType)
    {

        currentPortal = Portals[PortalType];
    }

}
