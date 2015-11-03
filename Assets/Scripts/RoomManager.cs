using UnityEngine;
using System.Collections;

public class RoomManager : MonoBehaviour {

    public GameObject[] rooms;
    public int currentRoom;
    public DayNightController dnControl;
    public Material[] SkyBoxes;

    // Use this for initialization
    void Start () 
    {
        currentRoom = 0;
        Cursor.visible = false;
        dnControl = this.GetComponent<DayNightController>();

        GameObject[] roomRes = GameObject.FindGameObjectsWithTag("Room");
        rooms = new GameObject[roomRes.Length];

        foreach (GameObject room in roomRes) {
            int roomID = System.Int32.Parse(room.gameObject.name.Replace("Room ", ""));
            
            rooms[roomID] = room;
            rooms[roomID].GetComponent<Room>().roomID = roomID;
        }


    }

    // Update is called once per frame
    void Update () 
    {

    }

    public void SetRoom(int id)
    {
        float[] dayTimes = { 0.1f, 0.5f, 0.9f, 0.2f, 0.4f, 0.8f, 0.3f, 0.8f, 0.6f };
        int[] skies = {0, 1, 0, 2, 1, 0,2, 1,0,2,1};
        dnControl.currentTimeOfDay = dayTimes[id];
        RenderSettings.skybox = SkyBoxes[skies[id]];
    }
}