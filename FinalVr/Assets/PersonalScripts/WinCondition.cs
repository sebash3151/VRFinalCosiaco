using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private AudioSource sound;
    [SerializeField] float time = 10f;
    private float timer = 0f;
    private bool win = false;
    private bool sonido = false;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (win)
        {
            timer += Time.deltaTime;
            if (timer >= time)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void Winner()
    {
        if (!sonido)
        {
            sound.Play();
            win = true;
            sonido = true;
        }

    }
}
