using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    //public Animator transition;
    //public float transitionTime = 1f;
    public int numeroEscena = 0;
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(numeroEscena);
        //StartCoroutine(LoadLevel(numeroEscena));
    }
    /*IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(numeroEscena);
    }*/
}      

