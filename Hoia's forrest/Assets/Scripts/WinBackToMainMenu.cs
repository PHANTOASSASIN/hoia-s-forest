using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinBackToMainMenu : MonoBehaviour
{
    public string timedis;
    public TMPro.TMP_Text time;

    void Start()
    { 

        timedis = PlayerPrefs.GetString("time");

        time.text = timedis;

    }


    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("main menu");
        }
    }
}
