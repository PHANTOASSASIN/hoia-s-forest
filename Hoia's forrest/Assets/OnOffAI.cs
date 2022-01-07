using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffAI : MonoBehaviour
{
    public int stuntime;

   public IEnumerator OnOff()
    {
        
        GetComponent<AIScript>().enabled = false;
        yield return new WaitForSeconds(stuntime);
        GetComponent<AIScript>().enabled = true;
    }
}
