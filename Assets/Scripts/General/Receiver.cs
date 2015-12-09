using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public interface Receiver
{
    void RayHit(float distance);
    void Activate();
}