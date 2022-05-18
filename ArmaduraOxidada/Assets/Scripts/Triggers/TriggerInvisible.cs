using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInvisible : MonoBehaviour
{
    public GameObject i1;
    public GameObject i2;
    public GameObject i3;
    public GameObject i4;
    public AudioSource Sonido;

    private void OnTriggerEnter(Collider other)
    {
        i1.GetComponent<MeshRenderer>().enabled = true;
        i2.GetComponent<MeshRenderer>().enabled = true;
        i3.GetComponent<MeshRenderer>().enabled = true;
        i4.GetComponent<MeshRenderer>().enabled = true;
        Sonido.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        i1.GetComponent<MeshRenderer>().enabled = false;
        i2.GetComponent<MeshRenderer>().enabled = false;
        i3.GetComponent<MeshRenderer>().enabled = false;
        i4.GetComponent<MeshRenderer>().enabled = false;
    }
}
