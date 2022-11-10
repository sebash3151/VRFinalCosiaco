using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] GameObject carta;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void cartear()
    {
        carta.SetActive(true);
    }
}
