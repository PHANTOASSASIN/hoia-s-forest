using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

    // Use this for initialization

    private string timedis;
    private float sec;
    private int min;
    private int hou;

    void Start()
    {
        sec = 0;
        min = 0;
        hou = 0;
    }

    // Update is called once per frame
    void Update()
    {

            //Adding milliseconds
            sec += Time.deltaTime;
            //Adding minutes
            if (Mathf.Floor(sec) >= 60) { sec = 0; min = min + 1; }
            //Adding hours
            if (min >= 60) { min = 0; hou = hou + 1; }
            //Display time
            timedis = (hou.ToString() + ":" + min.ToString() + ":"  + Mathf.Floor(sec).ToString());
            OnDisable();

    }

    void OnDisable()
    {
        PlayerPrefs.SetString("time", timedis);
        Debug.Log(timedis);
    }


}