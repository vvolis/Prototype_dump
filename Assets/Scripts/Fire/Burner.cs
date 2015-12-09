using UnityEngine;
using System.Collections;
public class Burner : MonoBehaviour, Receiver
{

    public float burntime = 10.0f;
    public float dieTime;
    public GameObject fire;
    public Color endcolor = Color.black;
    private Color startColor;
    public bool fired;

    public Color[] deltas;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = this.GetComponent<Renderer>();
        deltas = new Color[rend.materials.Length];
        for (int i = 0; i < deltas.Length; i++) {
            deltas[i] = rend.materials[i].color / burntime;
        }
        fired = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (fired) {
            if (burntime > dieTime) {
                for (int i = 0; i < deltas.Length; i++) {
                    rend.materials[i].color -= deltas[i];
                }
                burntime -= Time.deltaTime;
            } else {
                Destroy(this.gameObject);
            }
        }
    }

    public void Activate()
    {

    }
    public void RayHit(float distance)
    {
        if (!fired && distance < 4F) {
            fired = true;
            fire.SetActive(true);
            this.GetComponent<AudioSource>().Play();
        }
    }
}