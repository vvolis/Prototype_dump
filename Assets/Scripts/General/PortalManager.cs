using UnityEngine;
using System.Collections;

public class PortalManager : MonoBehaviour {
    public GameObject Portal1;
    public GameObject Portal2;
    public GameObject mainCam;
    public GameObject mainPortalCam;

    public void EnablePortals()
    {
        Debug.Log("Portals Enabled");
        this.transform.GetChild(0).gameObject.SetActive(true);
        Portal1.SetActive(true);
        Portal2.SetActive(true);
        mainPortalCam.SetActive(true);
        mainCam.SetActive(false);
    }

    public void DisablePortals()
    {
        Debug.Log("Portals Disabled");
        this.transform.GetChild(0).gameObject.SetActive(false);
        Portal1.SetActive(false);
        Portal2.SetActive(false);
        mainCam.SetActive(true);
        mainPortalCam.SetActive(false);
    }

}