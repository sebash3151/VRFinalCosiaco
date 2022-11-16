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

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void scroll0()
    {
        audio.Play();
        scrollInitial.SetActive(true);
        scrollInitialUI.SetActive(true);
    }

    public void scroll1VO()
    {
        audio.Play();
        scroll1.SetActive(true);
        scrollUI1.SetActive(true);
    }

    public void scroll2VO()
    {
        audio.Play();
        scroll2.SetActive(true);
        scrollUI2.SetActive(true);
    }

    public void scroll3VO()
    {
        audio.Play();
        scroll3.SetActive(true);
        scrollUI3.SetActive(true);

    }

    public void scroll4VO()
    {
        audio.Play();
        scroll4.SetActive(true);
        scrollUI4.SetActive(true);
    }
}
