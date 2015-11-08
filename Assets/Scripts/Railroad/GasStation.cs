using UnityEngine;
using System.Collections;

public class GasStation : MonoBehaviour, Receiver
{
    public GameObject train;

    public void Activate()
    {

    }
    public void RayHit()
    {
        train.SetActive(true);
    }
}