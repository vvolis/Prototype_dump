using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lamps : MonoBehaviour {

    public Transform[] children;
    public AudioClip shutDown;
    // Use this for initialization
    void Start ()
    {

    }

    public void SelfDestruct()
    {
        StartCoroutine(Destroyer());
    }

    IEnumerator Destroyer()
    {   int i=0;
        Transform audioS = this.transform.Find("AudioSource");
        while (i<children.Length) 
        {
            audioS.position = new Vector3(audioS.position.x, audioS.position.y, children[i].position.z + 225);
            Destroy(children[i].gameObject);
            audioS.GetComponent<AudioSource>().PlayOneShot(shutDown);
            yield return new WaitForSeconds(0.3F);
            i++;
        }
    }
}