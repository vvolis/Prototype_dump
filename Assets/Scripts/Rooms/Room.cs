using UnityEngine;
using System.Collections;

public class Room : MonoBehaviour {
    public int roomID;
    public RoomManager roomManager;


    // Use this for initialization
    void Start () 
    {
	    roomManager = GameObject.Find("GM").GetComponent<RoomManager>();
    }

    // Update is called once per frame
    void Update () 
    {

    }
}