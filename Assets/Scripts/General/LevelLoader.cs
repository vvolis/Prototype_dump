using UnityEngine;
using System.Collections;

public class LevelLoader :  MonoBehaviour
{
    public int lastLoaded;
    float startTime;

    public void Start()
    {
        lastLoaded = 0;
    }

    public void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space)) {
            startTime = Time.time;
            StartCoroutine(Load(lastLoaded+1));
        }*/
    }

    public void CleanUp (int levelNo)
    {

    }

    IEnumerator Load( int levelNo)
    {
        this.lastLoaded = levelNo;
        AsyncOperation async = Application.LoadLevelAdditiveAsync(levelNo);
        yield return async;
        Debug.Log("Loading level " + levelNo + " complete. It took " + (Time.time-startTime));
    }
}