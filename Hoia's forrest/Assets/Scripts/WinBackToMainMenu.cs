using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinBackToMainMenu : MonoBehaviour
{
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
