using UnityEngine;
using System.Collections;

public class TreeBranch : MonoBehaviour {

    public float speed;
    public float amount;
    public GameObject player;
    float distance;
    float greenValue;
    public float soundDist;
    public float soundFactor;
    public float lightDist;
    public float lightFactor;
    public float jitterDist;
    public float jitterFactor;
    public float jitterAmount;

    float x;
    float y;
    float z;
    public AudioSource audio1;
    // Use this for initialization
    void Start () 
    {
        audio1 = GetComponent<AudioSource>();
        audio1.PlayDelayed(Random.Range(0F, 3.0F));
        audio1.pitch = audio1.pitch + Random.Range(-3F, 3.0F);
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }

    // Update is called once per frame
    void FixedUpdate () 
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        //Debug.Log("distance" + distance);
        //Set brightness
        greenValue = (lightDist -distance) * lightFactor;
        this.GetComponent<Renderer>().material.color = new Color(0F, greenValue, 0F, 1F);
        //Set shake
        float jitter = (jitterDist - distance) * jitterFactor;
        //Set sound
        audio1.volume = (soundDist- distance) * soundFactor;
        transform.position = PositionJitter(jitter);
            //Random.InsideUnitCircle()
            
            //Mathf.Sin(Time.time * speed);
    }

    Vector3 PositionJitter(float jitter)
    {
        return new Vector3(
            Clamp(transform.position.x + Random.Range(-jitterAmount, jitterAmount), this.x - jitter, this.x + jitter),
            Clamp(transform.position.y + Random.Range(-jitterAmount, jitterAmount), this.y - jitter, this.y + jitter),
            Clamp(transform.position.z + Random.Range(-1.5F, 1.5F), this.z - jitter, this.z + jitter)
        );
    }

    public static float Clamp(float value, float min, float max)
    {
        return (value < min) ? min : (value > max) ? max : value;
    }

}