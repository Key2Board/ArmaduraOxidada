using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausar : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Camera;
    public AudioSource Musica;
    public AudioSource D1;
    public AudioSource D2;
    public AudioSource D3;
    public AudioSource D4;
    public AudioSource D5;
    public AudioSource D6;
    public AudioSource D7;
    public AudioSource D8;
    public AudioSource D9;
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
        /*D1.Play();
        D2.Play();
        D3.Play();
        D4.Play();
        D5.Play();
        D6.Play();
        D7.Play();
        D8.Play();
        D9.Play();*/
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
        /*D1.Pause();
        D2.Pause();
        D3.Pause();
        D4.Pause();
        D5.Pause();
        D6.Pause();
        D7.Pause();
        D8.Pause();
        D9.Pause();*/
        Camera.GetComponent<SFPSC_FPSCamera>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        GameIsPaused = true;
        Time.timeScale = 0f;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        //pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("MenuPrincipal");
    }
}

