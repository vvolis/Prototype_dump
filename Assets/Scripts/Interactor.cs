using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interactor : MonoBehaviour {

    void Update () 
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, 20F))
        {
            print("There is something in front of the object! hit transform" + hit.transform.name);
            Receiver hitReceiver = hit.transform.GetComponent<Receiver>();
            if (hitReceiver != null) 
            {
                hitReceiver.RayHit();
                if (Input.GetKeyDown(KeyCode.E)) {
                    hit.transform.GetComponent<Receiver>().Activate();
                }
                //print("There is something in front of the object! hit transform" + hit.transform.name);
            }
        } 
    }
}