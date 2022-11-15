using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] string targetTag;
    [SerializeField] float tiempo = 0f;
    [SerializeField] MeshRenderer targetMaterial;
    private float timer = 0f;
    private bool activado = false;
    [SerializeField] GameObject gema;
    [SerializeField] Material material;
    [SerializeField] bool vainosiodelmaterial = true;
    [SerializeField] AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (activado)
        {
            timer += Time.deltaTime;
            if (timer >= tiempo)
            {
                targetMaterial.material = material;
                gema.SetActive(true);
                audio.Stop();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            activado = true;
            if (vainosiodelmaterial)
            {
                audio.Play();
                targetMaterial = other.gameObject.GetComponent<MeshRenderer>();
            }
                      
        }
    }
}
