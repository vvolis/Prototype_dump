using UnityEngine;
using System.Collections;

public class GasStation : MonoBehaviour, Receiver
{
    public GameObject train;
    public GameObject player;
    public GameObject nextLevel;

    public void Activate()
    {

    }
    public void RayHit()
    {
        train.SetActive(true);
        player.GetComponent<PortalManager>().EnablePortals();
        nextLevel.SetActive(true);
    }
}