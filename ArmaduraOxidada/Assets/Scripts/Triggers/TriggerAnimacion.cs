using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimacion : MonoBehaviour
{
    [SerializeField] private Animator AbrirPorton;
    [SerializeField] private string abrirPorton = "AbrirPorton";
    bool triggered = false;
    void OnTriggerEnter(Collider other)
    {
        if (triggered != true)
        {
            if (other.CompareTag("Player"))
            {
                AbrirPorton.Play(abrirPorton, 0, 0.0f);
            }
            triggered = true;
        }

    }
}
