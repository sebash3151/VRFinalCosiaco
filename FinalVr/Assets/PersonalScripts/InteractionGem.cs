using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionGem : MonoBehaviour
{
    [SerializeField] string targetTag;
    [SerializeField] DoorUnlick gemScript;
    private bool activated = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            if (!activated)
            {
                gemScript.AddGem();
                activated = true;
            }               
        }
    }
}
