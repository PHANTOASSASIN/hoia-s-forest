using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
