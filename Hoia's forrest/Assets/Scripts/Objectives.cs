using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objectives : MonoBehaviour
{
    public bool hasCanister1 = false;
    public bool hasCanister2 = false;
    public bool hasKeys = false;

    public void takeKeys()
    {
        hasKeys = true;
    }

    public void takeCanister1()
    {
        hasCanister1 = true;
    }

    public void takeCanister2()
    {
        hasCanister2 = true;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (hasCanister1 == true && hasCanister2 == true && hasKeys == true)
            {
                SceneManager.LoadScene("Winning screen");
                Debug.Log("amangas");
            }
        }
    }
}
