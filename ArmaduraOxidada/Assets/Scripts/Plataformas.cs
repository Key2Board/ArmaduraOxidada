using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public GameObject Plataforma;
    public GameObject Jugador;

    void OnTriggerEnter(Collider other)
    {
        Jugador.transform.parent = Plataforma.transform;
    }
    void OnTriggerExit(Collider other)
    {
        Jugador.transform.parent = null;
    }
}