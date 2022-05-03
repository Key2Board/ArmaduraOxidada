using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    //public Camera cam;
    //public Transform cameraOrigin;

    void OnTriggerEnter(Collider collider)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        //cam.GetComponent<SFPSC_FPSCamera>().
        //cam.transform.LookAt(cameraOrigin);
    }
}
