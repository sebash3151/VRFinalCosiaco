using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCoso : MonoBehaviour
{
    private int estado = 0;
    private int estadoActual = 0;
    public GameObject ojeto;
    private int completo = 0;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (completo == 4)
        {
            ojeto.SetActive(true);
        }
    }

    public void Uno()
    {
        completo++;
        /*if (estadoActual == 0)
        {
            Debug.Log("estado 1");
            estado = 1;
            estadoActual = 1;
        }
        else
        {
            Debug.Log("estado 0");
            estadoActual = 0;
            audio.Play();
        }*/
    }

    public void Dos()
    {
        if (estadoActual == 1)
        {
            Debug.Log("estado 2");
            estado = 2;
            estadoActual = 2;
        }
        else
        {
            Debug.Log("estado 0");
            estadoActual = 0;
            audio.Play();
        }
        
    }

    public void Tres()
    {
        if (estadoActual == 2)
        {
            Debug.Log("estado 3");
            estado = 3;
            estadoActual = 3;
        }
        else
        {
            Debug.Log("estado 0");
            estadoActual = 0;
            audio.Play();
        }
    }

    public void Cuatro()
    {
        if (estadoActual == 3)
        {
            Debug.Log("estado 4");
            estado = 4;
            estadoActual = 4;
        }
        else
        {
            Debug.Log("estado 0");
            estadoActual = 0;
            audio.Play();
        }
    }
}
