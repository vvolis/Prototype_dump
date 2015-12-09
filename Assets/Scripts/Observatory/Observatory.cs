using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Observatory : MonoBehaviour, Receiver
{

    public Text text;
    public float hitTime;
    public float resetTime;
    public AudioClip clip1;
    public GameObject Railroad;
    public GameObject Lamp;

    public void Activate()
    {
        this.GetComponent<AudioSource>().PlayOneShot(clip1);
        this.GetComponent<Animator>().Play("Observatory");
        Railroad.SetActive(true);
        Lamp.GetComponent<Lamps>().SelfDestruct();
        Destroy(this.gameObject, 0.85F);
    }
    public void RayHit(float distance)
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