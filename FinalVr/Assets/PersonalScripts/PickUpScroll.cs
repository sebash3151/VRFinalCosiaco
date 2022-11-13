using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScroll : MonoBehaviour
{
    [SerializeField] GameObject scrollInitial;
    [SerializeField] GameObject scrollInitialUI;
    [SerializeField] GameObject scroll1;
    [SerializeField] GameObject scrollUI1;
    [SerializeField] GameObject scroll2;
    [SerializeField] GameObject scrollUI2;
    [SerializeField] GameObject scroll3;
    [SerializeField] GameObject scrollUI3;
    [SerializeField] GameObject scroll4;
    [SerializeField] GameObject scrollUI4;
    private AudioSource audio;
    private int number;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (number == 1)
        {
            scroll1.SetActive(true);
            scrollUI1.SetActive(true);
        }
        else if (number == 2)
        {
            scroll2.SetActive(true);
            scrollUI2.SetActive(true);
        }
        else if (number == 3)
        {
            scroll3.SetActive(true);
            scrollUI3.SetActive(true);
        }
        else if (number == 4)
        {
            scroll4.SetActive(true);
            scrollUI4.SetActive(true);
        }
        else if (number == 0)
        {
            scrollInitial.SetActive(true);
            scrollInitialUI.SetActive(true);
        }    
    }

    public void ScrollPickedUp(int numberu)
    {
        audio.Play();
        number = numberu;
    }
}
