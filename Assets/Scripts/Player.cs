using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    //public AudioClip impact;
    //AudioSource audio;
    void Update()
    {
    }
 
	void Start ()
	{
   //     audio = GetComponent<AudioSource>();
	}

    void OnCollisionEnter(Collision collision)
    {
    //    Debug.Log("hit");
    //    audio.PlayOneShot(impact);
        //audio.Play();
    }
}
