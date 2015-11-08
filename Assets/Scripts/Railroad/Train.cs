using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {

    public bool arrived;
    public float speed;
    public AudioClip horn;
    // This dude fires on setting enabled!
    void Start () 
    {
        arrived = false;
        this.GetComponent<AudioSource>().PlayOneShot(horn);
        this.GetComponent<AudioSource>().time= 2;
        Debug.Log("Train has arrived");
    }

    // Update is called once per frame
    void Update () 
    {
        if (!arrived) {
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided:" + other.name);
        if (other.gameObject.name == "stationTrig") {
            //this.GetComponent<AudioSource>().PlayOneShot(horn);
            arrived = true;
        }
    }

}