using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimacion : MonoBehaviour
{
    [SerializeField] private Animator Animador;
    [SerializeField] private string Animacion = "AbrirPorton";
    bool triggered = false;
    void OnTriggerEnter(Collider other)
    {
        if (triggered != true)
        {
            if (other.CompareTag("Player"))
            {
                Animador.Play(Animacion, 0, 0.0f);
            }
            triggered = true;
        }
        
    }
}
