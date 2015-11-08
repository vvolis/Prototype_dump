using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PCScript : MonoBehaviour, Receiver
{

    public Text PCtext;
    public Sprite PC1Texture1;
    public Sprite PC1Texture2;
    //public Sprite PC2Texture1;
    public Image PC1Image;
    // Use this for initialization
    public AudioClip clip1;

    public float hitTime;
    public float resetTime;
    void Start () 
    {
	 
    }

    // Update is called once per frame
    void Update () 
    {
        if (hitTime < Time.time - resetTime) {
             Reset();
        }
    }

    public void RayHit()
    {
        hitTime = Time.time;
        PC1Image.sprite = PC1Texture1;
        PCtext.enabled = true;
        Debug.Log("PCHit");
    }

    public void Reset()
    {
        PC1Image.sprite = PC1Texture2;
        PCtext.enabled = false;
    }

    public void Activate()
    {
        this.GetComponent<AudioSource>().PlayOneShot(clip1);
    }
}