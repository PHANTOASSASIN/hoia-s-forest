using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLaboratory : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        CharacterController cc = thePlayer.GetComponent<CharacterController>();

        cc.enabled = false;
        thePlayer.transform.position = teleportTarget.transform.position;
        cc.enabled = true;
    }
}
