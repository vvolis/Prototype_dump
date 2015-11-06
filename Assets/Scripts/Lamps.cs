using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lamps : MonoBehaviour {

    public Transform[] children;
    // Use this for initialization
    void Start () 
    {
	    List<Transform> temp = new List<Transform>();
        foreach (Transform child in this.transform) {
            temp.Add(child);
        }
        children = temp.ToArray();
    }

    public void SelfDestruct()
    {
        StartCoroutine(Destroyer());
    }

    IEnumerator Destroyer()
    {   int i=0;
        while (i<children.Length) 
        {
            if ((i + 1) % 2 == 0) {
                Destroy(children[i].gameObject);
                Destroy(children[i-1].gameObject);
                yield return new WaitForSeconds(0.3F);
            }
            i++;
        }
    }
}