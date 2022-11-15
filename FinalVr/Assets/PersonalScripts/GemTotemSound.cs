using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemTotemSound : MonoBehaviour
{
    private AudioSource audio;

    public void GemSound()
    {
        audio.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gem"))
        {
            audio = other.gameObject.GetComponent<AudioSource>();
        }
    }
}
