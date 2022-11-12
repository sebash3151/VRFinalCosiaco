using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlick : MonoBehaviour
{
    [SerializeField] int Gems = 0;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject door;

    void Update()
    {
        if (Gems == 4)
        {
            Debug.Log("finish");
            wall.SetActive(false);
            door.SetActive(true);
        }
    }

    public void AddGem()
    {
        Gems++;
    }

    public void MinusGem()
    {
        Gems--;
    }
}
