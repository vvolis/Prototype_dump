using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calendar : MonoBehaviour, Receiver
{
    public Text interactTxt;
    public Image calendarImage;
    public AudioClip tearPage;
    public GameObject leaf;

    //For interaction
    public float hitTime;

    void Start()
    {

    }


    void Update()
    {
        if (hitTime < Time.time) {
            Reset();
        }
    }

    public void RayHit(float distance)
    {
        hitTime = Time.time;
        interactTxt.enabled = true;
        Debug.Log("Calendar hit");
    }

    public void Reset()
    {
        interactTxt.enabled = false;
    }

    public void Activate()
    {
        leaf.GetComponent<Rigidbody>().AddForce(new Vector3(-1, -1, -1) * 8);
    }
}