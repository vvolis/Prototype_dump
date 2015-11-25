using UnityEngine;
using System.Collections;

public class Steve : MonoBehaviour {
    private float power;
    public float time;
    public float randDelay;
    public Transform target;
    public float damping;

    float deltaTime = 0.0f;
    // Use this for initialization
    void Start () 
    {
        time = 0;
        power = 170F;
        randDelay = Random.Range(-0.5F, 0.5F);
        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update ()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
      //  var targetPosition = target.position;
        //targetPosition.y = transform.position.y;
        //transform.LookAt(targetPosition);
        var lookPos = target.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        //transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        //Steves Radial scene
        //transform.LookAt(new Vector3(target.position.x, target.position.y, transform.position.z));
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > 1f + randDelay) {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0F, 1F, 0F) * power);
            time = 0;
        }
    }

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }
}