using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Niveles");
    }

    public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Debug.Log("Sales del juego");
        Application.Quit();
#endif
    }
    public void Nivel1()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void Nivel3()
    {
        SceneManager.LoadScene("Nivel3");
    }
    public void Nivel4()
    {
        SceneManager.LoadScene("Nivel4");
    }
    public void Regresar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
