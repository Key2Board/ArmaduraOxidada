using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public Animator transicionNegro;
    public float tiempoEspera;
    int menuPrincipal = 1;
    int Niveles = 2;
    int nivel1 = 3;
    int nivel2 = 4;
    int nivel3 = 5;
    int nivel4 = 6;
    public void Jugar()
    {
        StartCoroutine(Jugar(Niveles));
        //SceneManager.LoadScene("Niveles");
    }
    IEnumerator Jugar(int levelIndex)
    {
        transicionNegro.SetTrigger("Start");

        yield return new WaitForSeconds(tiempoEspera);

        SceneManager.LoadScene(levelIndex);
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
        StartCoroutine(Regresar(menuPrincipal));
        //SceneManager.LoadScene("MenuPrincipal");
    }
    IEnumerator Regresar(int levelIndex2)
    {
        transicionNegro.SetTrigger("Start");

        yield return new WaitForSeconds(tiempoEspera);

        SceneManager.LoadScene(levelIndex2);
    }
}
