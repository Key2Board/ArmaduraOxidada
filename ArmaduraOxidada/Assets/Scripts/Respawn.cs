using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject CheckpointLocation;
    public GameObject Pausa;
    void Update()
    {
        if(Pausa.GetComponent<Pausar>().IsPaused != true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Player.transform.position = CheckpointLocation.transform.position;
            }
        }
    }
}
