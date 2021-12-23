using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    Flashlight_PRO flashlight_PRO;


    void Start()
    {
        flashlight_PRO = GameObject.FindGameObjectWithTag("Flashlight").GetComponent<Flashlight_PRO>();
    }
    
    
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            flashlight_PRO.ReplaceBattery();
            Destroy (gameObject);
        }
    }
}
