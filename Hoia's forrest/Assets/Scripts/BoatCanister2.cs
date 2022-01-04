using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatCanister2 : MonoBehaviour
{
    Objectives objectives;


    void Start()
    {
        objectives = GameObject.FindGameObjectWithTag("Objectives").GetComponent<Objectives>();
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            objectives.takeCanister2();
            Destroy(gameObject);
        }
    }
}
