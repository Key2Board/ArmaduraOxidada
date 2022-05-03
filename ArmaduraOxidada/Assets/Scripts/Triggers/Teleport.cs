using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject checkpointLocation;
    //public Transform cameraTarget;
    //public GameObject cameraOrigin;

    void OnTriggerEnter(Collider collider)
    {
        checkpointLocation.transform.position = teleportTarget.transform.position;
        //cameraOrigin.transform.position = cameraTarget.transform.position;
    }
}
