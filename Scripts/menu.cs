using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{

    // Use this for initialization
    public void botonStart()
    {
        SceneManager.LoadScene(1);
    }
    public void botonMenu()
    {
        SceneManager.LoadScene(0);
   }
    public void botonSalir()
    {
        Debug.Log("Quitamos el juego");
        Application.Quit();
    }
}

