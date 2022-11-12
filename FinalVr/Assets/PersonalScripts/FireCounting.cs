using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCounting : MonoBehaviour
{
    [SerializeField] int TotalFires;
    [SerializeField] int actualFires = 0;
    [SerializeField] GameObject gem;

    void Update()
    {
        if (actualFires >= TotalFires)
        {
            gem.SetActive(true);
        }
    }

    public void ActivateFire()
    {
        actualFires++;
    }
}
