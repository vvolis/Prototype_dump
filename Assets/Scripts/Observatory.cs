using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Observatory : MonoBehaviour, Receiver
{

    public Text text;
    public float hitTime;
    public float resetTime;
    public AudioClip clip1;
    public void Activate()
    {
        this.GetComponent<AudioSource>().PlayOneShot(clip1);
        Destroy(this.gameObject, 0.7F);
    }
    public void RayHit()
    {
        text.enabled = true;
    }

    void Update()
    {
        if (hitTime < Time.time - resetTime) {
            Reset();
        }
    }

    public void Reset()
    {
        text.enabled = false;
    }
}