using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    private void Awake()
    {
        if (Application.isEditor == false)
            Debug.unityLogger.logEnabled = false;
    }

    public void LoadScene(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

     void PararSonido()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
        
    }

    public void Salir()
    {
        Application.Quit();
    }
}
