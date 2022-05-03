using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInvisible : MonoBehaviour
{
    public GameObject i1;
    public GameObject i2;
    public GameObject i3;
    public GameObject i4;
    private void OnTriggerEnter(Collider other)
    {
        i1.GetComponent<Renderer>().enabled = true;
        i2.GetComponent<Renderer>().enabled = true;
        i3.GetComponent<Renderer>().enabled = true;
        i4.GetComponent<Renderer>().enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        i1.GetComponent<Renderer>().enabled = false;
        i2.GetComponent<Renderer>().enabled = false;
        i3.GetComponent<Renderer>().enabled = false;
        i4.GetComponent<Renderer>().enabled = false;
    }
}
