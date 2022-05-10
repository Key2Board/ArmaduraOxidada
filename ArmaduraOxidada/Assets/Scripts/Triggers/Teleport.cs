using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject checkpointLocation;
    public AudioSource teleport;
    private bool activado = false;
    //public Transform cameraTarget;
    //public GameObject cameraOrigin;

    void OnTriggerEnter(Collider collider)
    {
        checkpointLocation.transform.position = teleportTarget.transform.position;
        if(activado == false)
        {
            teleport.Play();
            activado = true;
        }

        //cameraOrigin.transform.position = cameraTarget.transform.position;
    }
}
