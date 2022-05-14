using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transicionNegro;
    public int numeroEscena;
    public float tiempoEspera;

    private void OnTriggerEnter(Collider other)
    {
        LoadNextLevel();
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(numeroEscena));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transicionNegro.SetTrigger("Start");

        yield return new WaitForSeconds(tiempoEspera);

        SceneManager.LoadScene(levelIndex);
    }
}
