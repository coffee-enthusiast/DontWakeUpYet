using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform teleportPosition;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            CharacterController c = other.gameObject.GetComponent<CharacterController>();
            StarterAssets.FirstPersonController f = other.gameObject.GetComponent<StarterAssets.FirstPersonController>();
            c.enabled = false;
            f.enabled = false;
            other.gameObject.transform.position = teleportPosition.position + new Vector3(1,0,0);
            c.enabled = true;
            f.enabled = true;
        }
    }
}
