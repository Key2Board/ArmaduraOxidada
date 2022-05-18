using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transicionBlanco;
    public int numeroEscena;
    public float tiempoEspera;
    public GameObject Canvas;

    private void Start()
    {
        Canvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        LoadNextLevel();
    }
    public void LoadNextLevel()
    {
        //transicionBlanco.SetTrigger("Pre");
        StartCoroutine(LoadLevel(numeroEscena));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        Canvas.SetActive(true);

        transicionBlanco.SetTrigger("Start");


        yield return new WaitForSeconds(tiempoEspera);
        
        SceneManager.LoadSceneAsync(levelIndex);
    }
}
