using UnityEngine;
using System.Collections;

public class EntryTrigger : MonoBehaviour {

    public GameObject landscape;
    public MapDisplace displacement;
    public Room roomScript;

    public struct MapDisplace
    {
        public Vector3 diff, startPos;

        public Vector3 returnPos(int multiplier)
        {
            return this.startPos + this.diff * multiplier;
        }
    }

    // Use this for initialization
    void Start () 
    {
        roomScript = this.transform.parent.GetComponent<Room>();
        displacement.diff = new Vector3(-19.03f, -5.41f, -7.32f);
        displacement.startPos = new Vector3(-34.2f, -76.6f, 23.0f);
        landscape = GameObject.Find("Landscape");
    }

    // Update is called once per frame
    void Update () 
    {

    }

    void OnTriggerEnter(Collider other)
    {
        landscape.transform.position = displacement.returnPos(roomScript.roomID);
        roomScript.roomManager.SetRoom(roomScript.roomID + 1);
    }
}