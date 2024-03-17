using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip clip;
    public TextAlignment toggleMusic;


    void Start()
    {
        fuente.clip = clip;
    }

    
    public void Reproducir()
    {
        fuente.Play();
    }
    public void Callar()
    {
        fuente.Stop();
    }
}
