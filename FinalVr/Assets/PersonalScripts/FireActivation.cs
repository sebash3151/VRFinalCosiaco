using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireActivation : MonoBehaviour
{
    [SerializeField] string targetTag;
    [SerializeField] GameObject Fire;
    [SerializeField] FireCounting firecount;
    [SerializeField] private bool activate = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            if (!activate)
            {
                activate = true;
                Fire.SetActive(true);
                firecount.ActivateFire();          
            }          
        }
    }
}
