using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausar1 : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Camera;
    public AudioSource Musica;
    public AudioSource Pajaros;
    public AudioSource Rio;
    public AudioSource Tronco;
    public AudioSource Fuente;
    public bool IsPaused { get { return Pausar.GameIsPaused; } }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Musica.Play();
        Pajaros.Play();
        Tronco.Play();
        Rio.Play();
        Fuente.Play();
        Camera.GetComponent<SFPSC_FPSCamera>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Musica.Pause();
        Pajaros.Pause();
        Tronco.Pause();
        Rio.Pause();
        Fuente.Pause();
        Camera.GetComponent<SFPSC_FPSCamera>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        GameIsPaused = true;
        Time.timeScale = 0f;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal");
    }
}

