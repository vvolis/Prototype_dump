using UnityEngine;
using System.Collections;

public class Scaler : MonoBehaviour {
    public float scaleImpact;
    private GameObject player;
    // Use this for initialization
    void Start () 
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update () 
    {
        float distance = Vector3.Distance(player.transform.position, this.transform.position);
        this.transform.localScale = new Vector3(distance / scaleImpact, distance / scaleImpact, distance / scaleImpact);
    }
}