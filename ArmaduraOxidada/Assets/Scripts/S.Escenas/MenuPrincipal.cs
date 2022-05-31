using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public Animator transicionNegro;
    public float tiempoEspera;
    public int menuPrincipal = 1;
    public int Niveles = 2;
    public int nivel1 = 3;
    public int nivel2 = 4;
    public int nivel3 = 5;
    public int nivel4 = 6;
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
        StartCoroutine(uno(nivel1));
        //SceneManager.LoadScene("Nivel1");
    }
    IEnumerator uno(int levelIndex3)
    {
        transicionNegro.SetTrigger("Start");

        yield return new WaitForSeconds(tiempoEspera);

        SceneManager.LoadScene(levelIndex3);
    }

    public void Nivel2()
    {
        StartCoroutine(dos(nivel2));
        //SceneManager.LoadScene("Nivel2");
    }
    IEnumerator dos(int levelIndex4)
    {
        transicionNegro.SetTrigger("Start");

        yield return new WaitForSeconds(tiempoEspera);

        SceneManager.LoadScene(levelIndex4);
    }
    public void Nivel3()
    {
        StartCoroutine(tres(nivel3));
        //SceneManager.LoadScene("Nivel3");
    }
    IEnumerator tres(int levelIndex5)
    {
        transicionNegro.SetTrigger("Start");

        yield return new WaitForSeconds(tiempoEspera);

        SceneManager.LoadScene(levelIndex5);
    }
    public void Nivel4()
    {
        StartCoroutine(cuatro(nivel4));
        //SceneManager.LoadScene("Nivel4");
    }
    IEnumerator cuatro(int levelIndex6)
    {
        transicionNegro.SetTrigger("Start");

        yield return new WaitForSeconds(tiempoEspera);

        SceneManager.LoadScene(levelIndex6);
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
